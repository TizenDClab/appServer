//
// Tizen C++ SDK
// Copyright (c) 2012 Samsung Electronics Co., Ltd.
//
// Licensed under the Flora License, Version 1.1 (the License);
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://floralicense.org/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an AS IS BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

#include <FSysPowerManager.h>

#include "WebViewer.h"


using namespace Tizen::Base;
using namespace Tizen::Base::Utility;
using namespace Tizen::Graphics;
using namespace Tizen::Locales;
using namespace Tizen::System;
using namespace Tizen::App;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Web::Controls;
using namespace Tizen::Io;
using namespace Tizen::Base::Runtime;
using namespace Tizen::Base::Collection;

WebViewer::WebViewer(void)
	: WEB_URL_PREFIX_HTTP(L"http://")
	, __pMainForm(null)
	, __pWeb(null)
	, __pEdit(null)
	, __pButton(null)
	, __bTimerExpired(false)
 	, __count(10)
{

	 __timer.Construct(*this);

	String fileUrlPath(L"/tmp/my_url.txt");
	String fileListPath(L"/tmp/my_list.txt");
	result r = E_SUCCESS;
	r = file_url.Construct(fileUrlPath, "r+");
	r = file_list.Construct(fileListPath, "r+");
}


WebViewer::~WebViewer(void)
{
}


Application*
WebViewer::CreateInstance(void)
{
	// You can create the instance through another constructor.
	return new WebViewer();
}


bool
WebViewer::OnAppInitializing(AppRegistry& appRegistry)
{
	Frame* pAppFrame = new Frame();
	pAppFrame->Construct();
	AddFrame(*pAppFrame);

	result r = E_SUCCESS;

	r = CreateWebForm();
	TryCatch(r == E_SUCCESS, , "CreateWebForm() has failed.\n");
	return true;

CATCH:
	return false;
}

bool
WebViewer::OnAppTerminating(AppRegistry& appRegistry, bool forcedTermination)
{
	return true;
}


void
WebViewer::OnForeground(void)
{
	__pWeb->Resume();
}


void
WebViewer::OnBackground(void)
{
	__pWeb->Pause();
}


void
WebViewer::OnLowMemory(void)
{
}


void
WebViewer::OnBatteryLevelChanged(BatteryLevel batteryLevel)
{
}

result
WebViewer::CreateWebForm(void)
{
	result r = E_SUCCESS;
	Rectangle bound;
	WebSetting setting;

	Header* pHeader;
	Footer* pFooter;

	FooterItem footerItem1;
	FooterItem footerItem2;
	IAppFrame* pAppFrame = GetAppFrame();

	AppResource* pAppResource = Application::GetInstance()->GetAppResource();
	const Bitmap* pBitmap1 = pAppResource->GetBitmapN("/goto.png");
	const Bitmap* pBitmap2 = pAppResource->GetBitmapN("/goto_press.png");

	const String url = L"http://www.google.com/";

	TryReturn(pAppFrame != null, E_SYSTEM, "GetAppFrame() has failed.\n");

	//form
	__pMainForm = new (std::nothrow) Form();
	r = __pMainForm->Construct(FORM_STYLE_NORMAL | FORM_STYLE_PORTRAIT_INDICATOR | FORM_STYLE_LANDSCAPE_INDICATOR_AUTO_HIDE | FORM_STYLE_HEADER | FORM_STYLE_FOOTER);
	TryReturn(r == E_SUCCESS, r, "Form Construct() has failed. \n ");

	__pMainForm->AddOrientationEventListener(*this);
	__pMainForm->SetOrientation(ORIENTATION_AUTOMATIC_FOUR_DIRECTION);

	bound = __pMainForm->GetClientAreaBounds();

	pAppFrame->GetFrame()->AddControl(__pMainForm);
	pAppFrame->GetFrame()->SetCurrentForm(__pMainForm);

	//edit field
	__pEdit = new (std::nothrow) EditField();
	r = __pEdit->Construct(Rectangle(EDIT_LINE_LEFT_RIGHT_MARGIN, 0, bound.width - EDIT_LINE_LEFT_RIGHT_MARGIN, EDIT_LINE_HEIGHT),
			EDIT_FIELD_STYLE_URL_SMALL, INPUT_STYLE_FULLSCREEN, false, WEB_URL_EDIT_FIELD_MAX_SIZE /*GROUP_STYLE_NONE*/);
	TryReturn(r == E_SUCCESS, r, "Editfield Construct() has failed.\n ");
	__pEdit->AddTextEventListener(*this);
	//__pEdit->SetText(url);

	r = __pMainForm->AddControl(__pEdit);
	TryReturn(r == E_SUCCESS, r, "Addcontrol() has failed.\n ");

	//header
	pHeader = __pMainForm->GetHeader();
	pHeader->SetStyle(HEADER_STYLE_TITLE);
	pHeader->SetTitleText(L"CCTV Monitor");

	//footer
	pFooter = __pMainForm->GetFooter();
	pFooter->SetStyle(FOOTER_STYLE_BUTTON_TEXT);
	pFooter->AddActionEventListener(*this);
	__pMainForm->SetFormBackEventListener(this);

	//footer item
	footerItem1.Construct(AC_BUTTON_WEB_BACK);
	footerItem1.SetText(L"Display On");

	footerItem2.Construct(AC_BUTTON_WEB_FORWARD);
	footerItem2.SetText(L"Display Off");

	pFooter->AddItem(footerItem1);
	pFooter->AddItem(footerItem2);

	//button
	__pButton = new (std::nothrow) Button();
	r = __pButton->Construct(Rectangle(bound.width - BUTTON_WIDTH, 0, BUTTON_WIDTH, EDIT_LINE_HEIGHT), "");
	TryReturn(r == E_SUCCESS, r, "Button Construct() has failed.\n ");

	__pMainForm->SetBackgroundColor(pFooter->GetColor());

	__pButton->SetColor(BUTTON_STATUS_NORMAL, pFooter->GetColor());
	__pButton->SetColor(BUTTON_STATUS_PRESSED, pFooter->GetColor());

	__pButton->SetActionId(AC_BUTTON_WEB_GOTO);
	__pButton->SetNormalBackgroundBitmap(*pBitmap1);
	__pButton->SetPressedBackgroundBitmap(*pBitmap2);
	__pButton->AddActionEventListener(*this);

	//r = __pMainForm->AddControl(__pButton);
	TryReturn(r == E_SUCCESS, r, "Addcontrol() has failed.\n ");



	//Web
	__pWeb = new (std::nothrow) Web();

	bound = __pMainForm->GetClientAreaBounds();
	r = __pWeb->Construct(Rectangle(0, EDIT_LINE_HEIGHT + EDIT_LINE_BOTTOM_MARGIN, bound.width, bound.height - EDIT_LINE_HEIGHT - EDIT_LINE_BOTTOM_MARGIN));
	TryReturn(r == E_SUCCESS, r, "Web Construct() has failed.\n ");

	r = __pMainForm->AddControl(__pWeb);
	TryReturn(r == E_SUCCESS, r, "Addcontrol() has failed.\n ");

	setting.SetInputStyle(INPUT_STYLE_OVERLAY);
	r = __pWeb->SetSetting(setting);
	TryReturn(r == E_SUCCESS, r, "SetSetting() has failed.\n ");

	__pWeb->SetLoadingListener(this);
	__pWeb->SetWebKeypadEventListener(this);
	__pWeb->SetWebUiEventListener(this);

	__pWeb->SetFocus();


	//__pWeb->LoadUrl(url);
	//__pMainForm->RequestRedraw(true);

	delete pBitmap1;
	delete pBitmap2;

	return r;
}

void
WebViewer::OnActionPerformed(const Control& source, int actionId)
{
	String url;
	bool run = false;

	switch (actionId)
	{
	case AC_BUTTON_WEB_BACK:
	{
		//__pWeb->GoBack();


		__timer.Start(10);


	}
	break;

	case AC_BUTTON_WEB_FORWARD:
	{
		__bTimerExpired = true;
	}
	break;

	case AC_BUTTON_WEB_GOTO:
	{
		url = __pEdit->GetText();

		if (url.IsEmpty())
		{
			MessageBox messageBox;
			messageBox.Construct(L"", L"URL is empty", MSGBOX_STYLE_NONE, 2000);

			int modalResult = 0;
			messageBox.ShowAndWait(modalResult);

			return;
		}

		__pWeb->LoadUrl(GetValidUrl(url));
		__pMainForm->RequestRedraw(true);
	}
	break;

	case AC_BUTTON_WEB_STOP:
	{
		__pWeb->StopLoading();
	}
	break;

	default:
		break;
	}

	return;

}

void
WebViewer::OnOrientationChanged(const Control& source, OrientationStatus orientationStatus)
{
	Rectangle bound = __pMainForm->GetClientAreaBounds();

	__pEdit->SetBounds(Rectangle(EDIT_LINE_LEFT_RIGHT_MARGIN, 0, bound.width - BUTTON_WIDTH - EDIT_LINE_LEFT_RIGHT_MARGIN, EDIT_LINE_HEIGHT));
	__pButton->SetBounds(Rectangle(bound.width - BUTTON_WIDTH, 0, BUTTON_WIDTH, EDIT_LINE_HEIGHT));

	if (__pWeb->IsVisible())
	{
		__pWeb->SetBounds(Rectangle(0, EDIT_LINE_HEIGHT + EDIT_LINE_BOTTOM_MARGIN, bound.width, bound.height - EDIT_LINE_HEIGHT - EDIT_LINE_BOTTOM_MARGIN));
	}

	__pMainForm->Invalidate(true);
}

void
WebViewer::OnTextValueChangeCanceled(const Tizen::Ui::Control& source)
{
	__pWeb->SetFocus();
}

void
WebViewer::OnTextValueChanged(const Tizen::Ui::Control& source)
{
	__pWeb->SetFocus();
}

void
WebViewer::OnScreenOn(void)
{
}

void
WebViewer::OnScreenOff(void)
{
}

String
WebViewer::GetValidUrl(Tizen::Base::String& url)
{
	String absoluteUrl = url;
	Uri uri;

	uri.SetUri(url);
	if (uri.GetScheme() == L"")
	{
		absoluteUrl.Insert(WEB_URL_PREFIX_HTTP, 0);
	}
	return absoluteUrl;
}

bool
WebViewer::OnHttpAuthenticationRequestedN(const Tizen::Base::String& host, const Tizen::Base::String& realm, const Tizen::Web::Controls::AuthenticationChallenge& authentication)
{
	return false;
}

void
WebViewer::OnHttpAuthenticationCanceled(void)
{
}

void
WebViewer::OnLoadingStarted(void)
{
	SetButtonCancelImage();
}

void
WebViewer::OnLoadingCanceled(void)
{
	SetButtonGotoImage();
}

void
WebViewer::OnLoadingErrorOccurred(LoadingErrorType error, const String& reason)
{
	Tizen::Ui::Controls::MessageBox msgBox;
	int modalresult = 0;
	Tizen::Base::String errReason;

	switch (error)
	{
	case WEB_REQUEST_TIMEOUT:
	{
		errReason = Tizen::Base::String(L"Request Timeout");
	}
	break;

	case WEB_NO_CONNECTION:
	{
		errReason = Tizen::Base::String(L"Network is not in service");
	}
	break;

	case WEB_MIME_NOT_SUPPORTED:
	{
		errReason = Tizen::Base::String(L"The content type is not supported");
	}
	break;

	case WEB_BAD_URL:
	{
		errReason = Tizen::Base::String(L"The url is invalid");
	}
	break;

	case WEB_HTTP_RESPONSE:
	{
		errReason = Tizen::Base::String(L"HTTP Response");
	}
	break;

	case WEB_OUT_OF_MEMORY:
	{
		errReason = Tizen::Base::String(L"Page Too Large");
	}
	break;

	case WEB_REQUEST_MAX_EXCEEDED:
	{
		errReason = Tizen::Base::String(L"Request Max Exceeded");
	}
	break;

	case WEB_ERROR_UNKNOWN:
	default:
	{
		errReason = Tizen::Base::String(L"An Unknown Error");
	}
	break;
	}

	msgBox.Construct(L"LOADING ERROR TYPE", errReason, MSGBOX_STYLE_NONE, 3000);
	msgBox.ShowAndWait(modalresult);
	SetButtonGotoImage();
}

void
WebViewer::OnLoadingCompleted(void)
{
	SetUrl(__pWeb->GetUrl());
	SetButtonGotoImage();
}

void
WebViewer::OnEstimatedProgress(int progress)
{
}

void
WebViewer::OnPageTitleReceived(const Tizen::Base::String& title)
{
}

bool
WebViewer::OnLoadingRequested(const Tizen::Base::String& url, WebNavigationType type)
{
	AppLog("%S",url.GetPointer());
	SetUrl(url);
	return false;
}


void
WebViewer::SetUrl(const Tizen::Base::String& url)
{
	result r = E_SUCCESS;
	if (url.GetLength() < WEB_URL_EDIT_FIELD_MAX_SIZE)
	{
		//r = __pEdit->SetText(url);
		TryReturnVoid(r == E_SUCCESS, "Fail to update URL in the EditField.");
		__pMainForm->RequestRedraw (true);
	}
	else
	{
		AppLog("The length of the URL exceeds the limit of the length of text in this EditField.");
	}
}

DecisionPolicy
WebViewer::OnWebDataReceived(const Tizen::Base::String& mime, const Tizen::Net::Http::HttpHeader& header)
{
	return WEB_DECISION_CONTINUE;
}

void
WebViewer::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{
	AppLog("OnFormBackRequested.");

	if (__pWeb->CanGoBack() == true)
	{
		__pWeb->GoBack();
	}
	else
	{
		Terminate();
	}
}

void
WebViewer::OnWebKeypadWillOpen(Tizen::Web::Controls::Web& source)
{
	AppLog("OnWebKeypadWillOpen.");
}

void
WebViewer::OnWebKeypadOpened(Tizen::Web::Controls::Web& source)
{
	AppLog("OnWebKeypadOpened.");

	Rectangle bound = __pMainForm->GetClientAreaBounds();
	if (source.IsVisible())
	{
		source.SetSize(bound.width, bound.height - EDIT_LINE_HEIGHT - EDIT_LINE_BOTTOM_MARGIN);
	}
}

void
WebViewer::OnWebKeypadClosed(Tizen::Web::Controls::Web& source)
{
	AppLog("OnWebKeypadClosed.");
	Rectangle bound = __pMainForm->GetClientAreaBounds();
	source.SetSize(bound.width, bound.height - EDIT_LINE_HEIGHT - EDIT_LINE_BOTTOM_MARGIN);
}

void
WebViewer::OnWebKeypadBoundsChanged(Tizen::Web::Controls::Web &source)
{
	AppLog("OnWebKeypadBoundsChanged.");
	Rectangle bound = __pMainForm->GetClientAreaBounds();
	source.SetSize(bound.width, bound.height - EDIT_LINE_HEIGHT - EDIT_LINE_BOTTOM_MARGIN);
}

void
WebViewer::OnWebPageBlockSelected(Tizen::Web::Controls::Web &source, Tizen::Graphics::Point &startPoint, Tizen::Graphics::Point &endPoint)
{
}

void
WebViewer::OnWebPageShowRequested(Tizen::Web::Controls::Web &source)
{
}

void
WebViewer::OnWebWindowCloseRequested(Tizen::Web::Controls::Web &source)
{
}

Tizen::Web::Controls::Web*
WebViewer::OnWebWindowCreateRequested(void)
{
	MessageBox messageBox;
	messageBox.Construct(L"", L"WebViewer doesn't include new window creation.", MSGBOX_STYLE_NONE, 3000);

	int modalResult = 0;
	messageBox.ShowAndWait(modalResult);

	return null;
}

void
WebViewer::SetButtonGotoImage(void)
{
	AppResource* pAppResource = Application::GetInstance()->GetAppResource();
	const Bitmap* pBitmap1 = pAppResource->GetBitmapN("/goto.png");
	const Bitmap* pBitmap2 = pAppResource->GetBitmapN("/goto_press.png");

	__pButton->SetNormalBackgroundBitmap(*pBitmap1);
	__pButton->SetPressedBackgroundBitmap(*pBitmap2);
	__pButton->SetActionId(AC_BUTTON_WEB_GOTO);

	__pButton->Draw();

	delete pBitmap1;
	delete pBitmap2;
}

void
WebViewer::SetButtonCancelImage(void)
{
	AppResource* pAppResource = Application::GetInstance()->GetAppResource();
	const Bitmap* pBitmap1 = pAppResource->GetBitmapN("/cancel.png");
	const Bitmap* pBitmap2 = pAppResource->GetBitmapN("/cancel_press.png");

	__pButton->SetNormalBackgroundBitmap(*pBitmap1);
	__pButton->SetPressedBackgroundBitmap(*pBitmap2);
	__pButton->SetActionId(AC_BUTTON_WEB_STOP);

	__pButton->Draw();

	delete pBitmap1;
	delete pBitmap2;
}


void
WebViewer::OnTimerExpired(Timer& timer)
{


	result r = E_SUCCESS;



	String urlMsg;
	String listMsg;


    i++;

	r = file_url.Seek(FILESEEKPOSITION_BEGIN, 0);
	r = file_url.Read(urlMsg);
	//char* pBuffer = new char[testMsg.GetLength() + 1];
	//memcpy(urlMsg, pMappedAddr, testMsg.GetLength());

	__pEdit->SetText(urlMsg);


   // r = file_list.Seek(FILESEEKPOSITION_BEGIN, 0);
   // r = file_list.Read(listMsg);



//	__pWeb->LoadUrl(L"http://www.google.com");
	__pWeb->LoadUrl(urlMsg);
	__pMainForm->RequestRedraw(true);

	timer.Start(5);

    AppLog("TimerApp: Current count: %d\n", __count);
}

bool
WebViewer::IsTimerExpired() const
{
    return __bTimerExpired;
}


