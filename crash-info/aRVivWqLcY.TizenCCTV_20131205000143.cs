S/W Version Information
Model: Ref.Device-ODROID-U3
Tizen-Version: 2.2.1
Build-Number: Tizen_Ref.Device-ODROID-U3_20140828.1255
Build-Date: 2014.08.28 12:55:51

Crash Information
Process Name: TizenCCTV
PID: 1696
Date: 2013-12-05 00:01:43(GMT+0900)
Executable File Path: /opt/apps/aRVivWqLcY/bin/TizenCCTV
This process is multi-thread process
pid=1696 tid=1696
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 1696, uid 5000)

Register Information
r0   = 0xa000076c, r1   = 0xa000076c
r2   = 0x00000000, r3   = 0x00000073
r4   = 0xa000076c, r5   = 0xbed4bf50
r6   = 0xb6bde000, r7   = 0xb69ee4d0
r8   = 0x0000009e, r9   = 0xbed4c8f0
r10  = 0xbed4c4a4, fp   = 0xbed4bf44
ip   = 0x00000000, sp   = 0xbed4b9f0
lr   = 0xb6af5f3c, pc   = 0xb6b28184
cpsr = 0x60000010

Memory Information
MemTotal:  2059832 KB
MemFree:   1584604 KB
Buffers:     23956 KB
Cached:     191936 KB
VmPeak:     102280 KB
VmSize:     102276 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       13548 KB
VmRSS:       13548 KB
VmData:       7184 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       64696 KB
VmPTE:          84 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 000dd000 rw-p [heap]
b0e5e000 b0e63000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b0e6c000 b0e76000 r-xp /usr/lib/libdrm-client.so.0.0.1
b0e7e000 b0ea8000 r-xp /usr/lib/libSLP-location.so.0.0.0
b0eb1000 b0eb7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.1.0
b0ebf000 b0ec8000 r-xp /usr/lib/libdownload-provider-interface.so.1.1.6
b0ed0000 b0ee2000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b0eea000 b0eef000 r-xp /usr/lib/libmmffile.so.0.0.0
b0ef7000 b0efe000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b0f06000 b0f08000 r-xp /usr/lib/libmedia-hash.so.1.0.0
b0f10000 b0f29000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b0f31000 b0f33000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b0f3b000 b0f53000 r-xp /usr/lib/libmedia-service.so.1.0.0
b0f5b000 b0f6f000 r-xp /usr/lib/libnetwork.so.0.0.0
b0f78000 b0f7d000 r-xp /usr/lib/libmemenv.so.1.1.0
b0f85000 b0fc3000 r-xp /usr/lib/libleveldb.so.1.1.0
b0fcc000 b0fd4000 r-xp /usr/lib/libgstfft-0.10.so.0.25.0
b0fdc000 b1006000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b100f000 b101e000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b1026000 b103e000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b1040000 b1065000 r-xp /usr/lib/libxslt.so.1.1.16
b106e000 b1072000 r-xp /usr/lib/libeukit.so.1.7.99
b107a000 b1082000 r-xp /usr/lib/libui-gadget-1.so.0.1.0
b108a000 b1095000 r-xp /usr/lib/libcapi-location-manager.so.0.1.11
b109d000 b10a0000 r-xp /usr/lib/libcapi-telephony-network-info.so.0.1.0
b10a9000 b10b2000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b10bb000 b10cf000 r-xp /usr/lib/libwifi-direct.so.0.0
b10d7000 b10df000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b10e0000 b10e4000 r-xp /usr/lib/libcapi-web-url-download.so.0.1.0
b10ec000 b1104000 r-xp /usr/lib/osp/libosp-locations.so.1.2.2.3
b1105000 b110a000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b1112000 b1133000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.59
b113b000 b1144000 r-xp /usr/lib/libcapi-network-connection.so.0.1.3_18
b114c000 b1154000 r-xp /usr/lib/libcapi-web-favorites.so
b1155000 b2357000 r-xp /usr/lib/libewebkit2.so.0.11.113
b243c000 b2501000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b250f000 b252c000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b2535000 b254f000 r-xp /usr/lib/osp/libosp-json.so.1.2.2.0
b2559000 b25b6000 r-xp /usr/lib/osp/libosp-content.so.1.2.2.0
b25bf000 b2633000 r-xp /usr/lib/osp/libosp-web.so.1.2.2.0
b2654000 b2661000 r-xp /opt/usr/apps/aRVivWqLcY/bin/TizenCCTV.exe
b2669000 b26db000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b26e3000 b271d000 r-xp /usr/lib/libpulsecommon-0.9.23.so
b2726000 b272a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b2732000 b2763000 r-xp /usr/lib/libpulse.so.0.12.4
b276b000 b27ce000 r-xp /usr/lib/libasound.so.2.0.0
b27d8000 b27db000 r-xp /usr/lib/libpulse-simple.so.0.0.3
b27e3000 b27e7000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b27f0000 b280d000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b2815000 b2823000 r-xp /usr/lib/libmmfsound.so.0.1.0
b282b000 b28c7000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b28d3000 b2914000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b291d000 b2926000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b292e000 b293b000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b2944000 b2947000 r-xp /usr/lib/libmm_ta.so.0.0.0
b294f000 b295e000 r-xp /usr/lib/libICE.so.6.3.0
b2968000 b296d000 r-xp /usr/lib/libSM.so.6.0.1
b2975000 b2976000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b297e000 b2986000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b298e000 b2996000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b29a1000 b29a4000 r-xp /usr/lib/libmmfsession.so.0.0.0
b29ac000 b29f0000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b29f9000 b29ff000 r-xp /usr/lib/libUMP.so
b2a07000 b2a0d000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2a15000 b2a16000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b2a1f000 b2a6a000 r-xp /usr/lib/libtiff.so.5.1.0
b2a75000 b2a9e000 r-xp /usr/lib/libturbojpeg.so
b2ab7000 b2abd000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b2ac5000 b2acb000 r-xp /usr/lib/libgif.so.4.1.6
b2ad3000 b2af5000 r-xp /usr/lib/libavutil.so.51.73.101
b2b04000 b2b32000 r-xp /usr/lib/libswscale.so.2.1.101
b2b3b000 b2e32000 r-xp /usr/lib/libavcodec.so.54.59.100
b3159000 b3172000 r-xp /usr/lib/libpng12.so.0.50.0
b317b000 b3181000 r-xp /usr/lib/libfeedback.so.0.1.4
b3189000 b3195000 r-xp /usr/lib/libtts.so
b319d000 b32eb000 r-xp /usr/lib/libMali.so
b32f7000 b33ae000 r-xp /usr/lib/libcairo.so.2.11200.12
b33b8000 b33d2000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b33db000 b3cd6000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b3d49000 b3d4e000 r-xp /usr/lib/libslp_devman_plugin.so
b3d57000 b3d5a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d62000 b3d66000 r-xp /usr/lib/libsysman.so.0.2.0
b3d6e000 b3d7f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3d88000 b3d8a000 r-xp /usr/lib/libsystemd-daemon.so.0.0.1
b3d92000 b3d94000 r-xp /usr/lib/libdeviced.so.0.1.0
b3d9c000 b3db2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b3dba000 b3dbc000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3dc4000 b3dc7000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3dcf000 b3dd2000 r-xp /usr/lib/libdevice-node.so.0.1
b3dda000 b3dde000 r-xp /usr/lib/libheynoti.so.0.0.2
b3de6000 b3e2b000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b3e34000 b3e49000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b3e52000 b3e56000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3e5e000 b3e63000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3e6b000 b3e6c000 r-xp /usr/lib/libcapi-system-power.so.0.1.1
b3e75000 b3e78000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b3e80000 b3e83000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b3e8c000 b3e8f000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b3e97000 b3e98000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b3ea0000 b3eae000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b3eb7000 b3ed9000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b3ee1000 b3ee4000 r-xp /usr/lib/libuuid.so.1.3.0
b3eed000 b3f0b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b3f13000 b3f2a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3f33000 b3f34000 r-xp /usr/lib/libpmapi.so.1.2
b3f3c000 b3f44000 r-xp /usr/lib/libminizip.so.1.0.0
b3f4c000 b3f57000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b3f5f000 b4037000 r-xp /usr/lib/libxml2.so.2.7.8
b4044000 b4062000 r-xp /usr/lib/libpcre.so.0.0.1
b406a000 b406d000 r-xp /usr/lib/libiniparser.so.0
b4076000 b407a000 r-xp /usr/lib/libhaptic.so.0.1
b4082000 b408d000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b409a000 b409f000 r-xp /usr/lib/libdevman.so.0.1
b40a8000 b40ac000 r-xp /usr/lib/libchromium.so.1.0
b40b4000 b40ba000 r-xp /usr/lib/libappsvc.so.0.1.0
b40c2000 b40c3000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b40cb000 b40d1000 r-xp /usr/lib/libalarm.so.0.0.0
b40da000 b40e3000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b40ec000 b40fe000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.5
b4106000 b4405000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b442c000 b4436000 r-xp /lib/libnss_files-2.13.so
b443f000 b4448000 r-xp /lib/libnss_nis-2.13.so
b4451000 b4462000 r-xp /lib/libnsl-2.13.so
b446d000 b4473000 r-xp /lib/libnss_compat-2.13.so
b479b000 b47ac000 r-xp /usr/lib/libcom-core.so.0.0.1
b47b4000 b47b6000 r-xp /usr/lib/libdri2.so.0.0.0
b47be000 b47c6000 r-xp /usr/lib/libdrm.so.2.4.0
b47ce000 b47d2000 r-xp /usr/lib/libtbm.so.1.0.0
b47da000 b47dd000 r-xp /usr/lib/libXv.so.1.0.0
b47e5000 b48b0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b48c6000 b48d6000 r-xp /usr/lib/libnotification.so.0.1.0
b48de000 b48e5000 r-xp /usr/lib/libutilX.so.1.1.0
b48ed000 b4911000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b491a000 b492a000 r-xp /lib/libresolv-2.13.so
b492e000 b4930000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b4938000 b4a8b000 r-xp /usr/lib/libcrypto.so.1.0.0
b4aa9000 b4af5000 r-xp /usr/lib/libssl.so.1.0.0
b4b01000 b4b2d000 r-xp /usr/lib/libidn.so.11.5.44
b4b36000 b4b40000 r-xp /usr/lib/libcares.so.2.0.0
b4b48000 b4b5f000 r-xp /lib/libexpat.so.1.5.2
b4b69000 b4b8d000 r-xp /usr/lib/libicule.so.48.1
b4b96000 b4b9e000 r-xp /usr/lib/libsf_common.so
b4ba6000 b4c41000 r-xp /usr/lib/libstdc++.so.6.0.14
b4c54000 b4d31000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4d3c000 b4d61000 r-xp /usr/lib/libexif.so.12.3.3
b4d75000 b4d7f000 r-xp /usr/lib/libethumb.so.1.7.99
b4d87000 b4dcb000 r-xp /usr/lib/libsndfile.so.1.0.25
b4dd9000 b4ddb000 r-xp /usr/lib/libctxdata.so.0.0.0
b4de3000 b4df1000 r-xp /usr/lib/libremix.so.0.0.0
b4df9000 b4dfa000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4e02000 b4e1b000 r-xp /usr/lib/liblua-5.1.so
b4e24000 b4e2b000 r-xp /usr/lib/libembryo.so.1.7.99
b4e34000 b4e37000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4e3f000 b4e7c000 r-xp /usr/lib/libcurl.so.4.3.0
b4e86000 b4e8a000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4e93000 b4efd000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4f0a000 b4f2e000 r-xp /usr/lib/libfontconfig.so.1.5.0
b4f37000 b4f93000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b4fa5000 b4fb9000 r-xp /usr/lib/libfribidi.so.0.3.1
b4fc1000 b5016000 r-xp /usr/lib/libfreetype.so.6.8.1
b5021000 b5045000 r-xp /usr/lib/libjpeg.so.8.0.2
b505d000 b5074000 r-xp /lib/libz.so.1.2.5
b507c000 b5089000 r-xp /usr/lib/libsensor.so.1.1.0
b5094000 b5096000 r-xp /usr/lib/libapp-checker.so.0.1.0
b509e000 b50a4000 r-xp /usr/lib/libxdgmime.so.1.1.0
b61bb000 b62a3000 r-xp /usr/lib/libicuuc.so.48.1
b62b0000 b63d0000 r-xp /usr/lib/libicui18n.so.48.1
b63de000 b63e1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b63e9000 b63f2000 r-xp /usr/lib/libvconf.so.0.2.45
b63fa000 b6408000 r-xp /usr/lib/libail.so.0.1.0
b6410000 b6428000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6429000 b642e000 r-xp /usr/lib/libffi.so.5.0.10
b6436000 b6437000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b643f000 b6449000 r-xp /usr/lib/libXext.so.6.4.0
b6452000 b6455000 r-xp /usr/lib/libXtst.so.6.1.0
b645d000 b6463000 r-xp /usr/lib/libXrender.so.1.3.0
b646b000 b6471000 r-xp /usr/lib/libXrandr.so.2.2.0
b6479000 b647a000 r-xp /usr/lib/libXinerama.so.1.0.0
b6483000 b648c000 r-xp /usr/lib/libXi.so.6.1.0
b6494000 b6497000 r-xp /usr/lib/libXfixes.so.3.1.0
b649f000 b64a1000 r-xp /usr/lib/libXgesture.so.7.0.0
b64a9000 b64ab000 r-xp /usr/lib/libXcomposite.so.1.0.0
b64b3000 b64b4000 r-xp /usr/lib/libXdamage.so.1.1.0
b64bd000 b64c4000 r-xp /usr/lib/libXcursor.so.1.0.2
b64cc000 b64d4000 r-xp /usr/lib/libemotion.so.1.7.99
b64dc000 b64f7000 r-xp /usr/lib/libecore_con.so.1.7.99
b6500000 b6505000 r-xp /usr/lib/libecore_imf.so.1.7.99
b650e000 b6516000 r-xp /usr/lib/libethumb_client.so.1.7.99
b651e000 b6520000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b6528000 b652c000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6535000 b654b000 r-xp /usr/lib/libefreet.so.1.7.99
b6555000 b655e000 r-xp /usr/lib/libedbus.so.1.7.99
b6566000 b656b000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6574000 b65d0000 r-xp /usr/lib/libedje.so.1.7.99
b65da000 b65f1000 r-xp /usr/lib/libecore_input.so.1.7.99
b660c000 b6611000 r-xp /usr/lib/libecore_file.so.1.7.99
b6619000 b6636000 r-xp /usr/lib/libecore_evas.so.1.7.99
b663f000 b667e000 r-xp /usr/lib/libeina.so.1.7.99
b6687000 b6736000 r-xp /usr/lib/libevas.so.1.7.99
b6758000 b676b000 r-xp /usr/lib/libeet.so.1.7.99
b6774000 b67de000 r-xp /lib/libm-2.13.so
b67e7000 b67ec000 r-xp /usr/lib/libappcore-common.so.1.1
b67f4000 b67ff000 r-xp /usr/lib/libaul.so.0.1.0
b6808000 b683c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6845000 b6875000 r-xp /usr/lib/libecore_x.so.1.7.99
b687e000 b6893000 r-xp /usr/lib/libecore.so.1.7.99
b68aa000 b69ca000 r-xp /usr/lib/libelementary.so.1.7.99
b69e4000 b69e6000 r-xp /opt/usr/apps/aRVivWqLcY/bin/TizenCCTV
b69f0000 b69f3000 r-xp /lib/libattr.so.1.1.0
b69fb000 b69fd000 r-xp /usr/lib/libXau.so.6.0.0
b6a05000 b6a0b000 r-xp /lib/librt-2.13.so
b6a14000 b6a1c000 r-xp /lib/libcrypt-2.13.so
b6a4c000 b6a4f000 r-xp /lib/libcap.so.2.21
b6a57000 b6a59000 r-xp /usr/lib/libiri.so
b6a61000 b6a76000 r-xp /usr/lib/libxcb.so.1.1.0
b6a7e000 b6a89000 r-xp /lib/libunwind.so.8.0.1
b6ab7000 b6bd4000 r-xp /lib/libc-2.13.so
b6be2000 b6beb000 r-xp /lib/libgcc_s-4.5.3.so.1
b6bf3000 b6bf6000 r-xp /usr/lib/libsmack.so.1.0.0
b6bfe000 b6c2a000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6c33000 b6c37000 r-xp /usr/lib/libbundle.so.0.1.22
b6c3f000 b6c41000 r-xp /lib/libdl-2.13.so
b6c4a000 b6d24000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d2d000 b6d97000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6da1000 b6dae000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6db7000 b6e9d000 r-xp /usr/lib/libX11.so.6.3.0
b6ea8000 b6ebc000 r-xp /lib/libpthread-2.13.so
b6ec7000 b6ec8000 r-xp /usr/lib/libdlog.so.0.0.0
b6ed5000 b6ed9000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ee2000 b6ee6000 r-xp /usr/lib/libsys-assert.so
b6eee000 b6f0b000 r-xp /lib/ld-2.13.so
bed2d000 bed4e000 rwxp [stack]
End of Maps Information

Callstack Information (PID:1696)
Call Stack Count: 12
 0: strlen + 0x4 (0xb6b28184) [/lib/libc.so.6] + 0x71184
 1: _IO_vfprintf + 0x3e84 (0xb6af5f3c) [/lib/libc.so.6] + 0x3ef3c
 2: __vsnprintf_chk + 0xa0 (0xb6b8fb0c) [/lib/libc.so.6] + 0xd8b0c
 3: __dlog_vprint + 0x5c (0xb6ec7a45) [/usr/lib/libdlog.so.0] + 0xa45
 4: SysTryReturnResultInternal + 0xbc (0xb4239a41) [/usr/lib/osp/libosp-appfw.so] + 0x133a41
 5: Tizen::App::UiApp::Execute(Tizen::App::UiApp* (*)(), Tizen::Base::Collection::IList const*) + 0x172 (0xb3a86307) [/usr/lib/osp/libosp-uifw.so] + 0x6ab307
 6: OspMain + 0x1c4 (0xb265e780) [/opt/apps/aRVivWqLcY/bin/TizenCCTV.exe] + 0xa780
 7: main + 0x194 (0xb69e4f21) [/opt/apps/aRVivWqLcY/bin/TizenCCTV] + 0xf21
 8: __launchpad_main_loop + 0xe54 (0xb259) [/usr/bin/launchpad_preloading_preinitializing_daemon] + 0xb259
 9: main + 0x486 (0xbcb3) [/usr/bin/launchpad_preloading_preinitializing_daemon] + 0xbcb3
10: __libc_start_main + 0x114 (0xb6acc6e8) [/lib/libc.so.6] + 0x156e8
11: (0xa110) [/usr/bin/launchpad_preloading_preinitializing_daemon] + 0xa110
End of Call Stack

Package Information
Package Name: aRVivWqLcY.TizenCCTV
Package ID : aRVivWqLcY
Version: 2.0.0
Package Type: tpk
App Name: TizenCCTV
App ID: aRVivWqLcY.TizenCCTV
Type: Application
Categories: (NULL)

Latest Debug Message Information
--------- beginning of /dev/log_main
01-01 10:00:19.955 E/Tizen::Base::Runtime(  465): static Tizen::Base::Runtime::_EventManager* Tizen::Base::Runtime::_EventManager::GetCurrentEventManager()(292) > [E_OBJ_NOT_FOUND] This is not OSP thread.
01-01 10:00:19.955 E/Tizen::Base::Runtime(  465): result Tizen::Base::Runtime::_Event::Initialize()(207) > [E_INVALID_OPERATION] Event manager does not exist.
01-01 10:00:19.955 E/Tizen::Base::Runtime(  467): static Tizen::Base::Runtime::_EventManager* Tizen::Base::Runtime::_EventManager::GetCurrentEventManager()(292) > [E_OBJ_NOT_FOUND] This is not OSP thread.
01-01 10:00:19.955 E/Tizen::Base::Runtime(  467): result Tizen::Base::Runtime::_Event::Initialize()(207) > [E_INVALID_OPERATION] Event manager does not exist.
01-01 10:00:24.410 E/Tizen::Base::Runtime( 1035): static Tizen::Base::Runtime::_EventManager* Tizen::Base::Runtime::_EventManager::GetCurrentEventManager()(292) > [E_OBJ_NOT_FOUND] This is not OSP thread.
01-01 10:00:24.410 E/Tizen::Base::Runtime( 1035): result Tizen::Base::Runtime::_Event::Initialize()(207) > [E_INVALID_OPERATION] Event manager does not exist.
01-01 10:00:24.425 I/osp-app-service( 1035): int OspMain(int, char**)(36) > Application started.
01-01 10:00:29.435 E/Tizen::Io( 1035): result Tizen::Io::_IpcClient::MakeConnection(bool)(205) > [E_SYSTEM] Failed to connect to server(/var/run/osp/osp.sys.ipcserver.setting_service) : No such file or directory
01-01 10:00:29.435 E/Tizen::Io( 1035): result Tizen::Io::_IpcClient::Construct(const Tizen::Base::String&, const Tizen::Io::_IIpcClientEventListener*)(103) > [E_SYSTEM] Failed to connect to server.
01-01 10:00:29.435 E/Tizen::System( 1035): result Tizen::System::_SettingClient::Construct()(248) > [E_SYSTEM] It is failed to construct IPC client.
01-01 10:00:29.435 E/Tizen::System( 1035): static void Tizen::System::_SettingClient::InitSettingClient()(179) > It is failed to create SettingClient by [E_SYSTEM].
01-01 10:00:29.435 E/Tizen::System( 1035): static result Tizen::System::_SettingInfoImpl::AddSettingEventListenerForInternal(Tizen::System::ISettingEventListener&)(373) > [E_SYSTEM] It is failed to intialize setting manager
01-01 10:00:40.810 E/Tizen::System( 1035): static result Tizen::System::_PowerManagerImpl::AddBootEventListener(Tizen::System::IBootEventListener&)(953) > [E_SYSTEM] It failed to add BootEvent listener.
01-01 10:00:40.925 E/Tizen::Base::Runtime( 1122): static Tizen::Base::Runtime::_EventManager* Tizen::Base::Runtime::_EventManager::GetCurrentEventManager()(292) > [E_OBJ_NOT_FOUND] This is not OSP thread.
01-01 10:00:40.925 E/Tizen::Base::Runtime( 1122): result Tizen::Base::Runtime::_Event::Initialize()(207) > [E_INVALID_OPERATION] Event manager does not exist.
01-01 10:00:40.935 E/Tizen::Base::Runtime( 1123): static Tizen::Base::Runtime::_EventManager* Tizen::Base::Runtime::_EventManager::GetCurrentEventManager()(292) > [E_OBJ_NOT_FOUND] This is not OSP thread.
01-01 10:00:40.935 E/Tizen::Base::Runtime( 1123): result Tizen::Base::Runtime::_Event::Initialize()(207) > [E_INVALID_OPERATION] Event manager does not exist.
01-01 10:00:40.945 I/osp-security-service( 1122): int OspMain(int, char**)(54) > Application started.
01-01 10:00:40.950 I/osp-channel-service( 1123): int OspMain(int, char**)(35) > Application started.
01-01 10:00:42.705 E/Tizen::Base::Runtime( 1124): static Tizen::Base::Runtime::_EventManager* Tizen::Base::Runtime::_EventManager::GetCurrentEventManager()(292) > [E_OBJ_NOT_FOUND] This is not OSP thread.
01-01 10:00:42.705 E/Tizen::Base::Runtime( 1124): result Tizen::Base::Runtime::_Event::Initialize()(207) > [E_INVALID_OPERATION] Event manager does not exist.
01-01 10:00:43.190 I/osp-common-service( 1124): int OspMain(int, char**)(38) > Application started.
01-01 10:00:45.950 E/Tizen::Io( 1122): result Tizen::Io::_IpcClient::MakeConnection(bool)(205) > [E_SYSTEM] Failed to connect to server(/var/run/osp/osp.sys.ipcserver.setting_service) : No such file or directory
01-01 10:00:45.950 E/Tizen::Io( 1122): result Tizen::Io::_IpcClient::Construct(const Tizen::Base::String&, const Tizen::Io::_IIpcClientEventListener*)(103) > [E_SYSTEM] Failed to connect to server.
01-01 10:00:45.950 E/Tizen::System( 1122): result Tizen::System::_SettingClient::Construct()(248) > [E_SYSTEM] It is failed to construct IPC client.
01-01 10:00:45.950 E/Tizen::System( 1122): static void Tizen::System::_SettingClient::InitSettingClient()(179) > It is failed to create SettingClient by [E_SYSTEM].
01-01 10:00:45.950 E/Tizen::System( 1122): static result Tizen::System::_SettingInfoImpl::AddSettingEventListenerForInternal(Tizen::System::ISettingEventListener&)(373) > [E_SYSTEM] It is failed to intialize setting manager
01-01 10:00:45.955 E/Tizen::Io( 1123): result Tizen::Io::_IpcClient::MakeConnection(bool)(205) > [E_SYSTEM] Failed to connect to server(/var/run/osp/osp.sys.ipcserver.setting_service) : No such file or directory
01-01 10:00:45.955 E/Tizen::Io( 1123): result Tizen::Io::_IpcClient::Construct(const Tizen::Base::String&, const Tizen::Io::_IIpcClientEventListener*)(103) > [E_SYSTEM] Failed to connect to server.
01-01 10:00:45.955 E/Tizen::System( 1123): result Tizen::System::_SettingClient::Construct()(248) > [E_SYSTEM] It is failed to construct IPC client.
01-01 10:00:45.955 E/Tizen::System( 1123): static void Tizen::System::_SettingClient::InitSettingClient()(179) > It is failed to create SettingClient by [E_SYSTEM].
01-01 10:00:45.955 E/Tizen::System( 1123): static result Tizen::System::_SettingInfoImpl::AddSettingEventListenerForInternal(Tizen::System::ISettingEventListener&)(373) > [E_SYSTEM] It is failed to intialize setting manager
01-01 10:00:46.120 I/osp-security-service( 1122): virtual bool SecurityService::OnAppInitializing(Tizen::App::AppRegistry&)(82) > Enter
01-01 10:00:46.120 I/osp-security-service( 1122): result PrivilegeService::Construct()(62) > Entered.
01-01 10:00:46.120 I/osp-security-service( 1122): result PrivilegeService::Construct()(70) > Leaved.
01-01 10:00:46.120 I/osp-security-service( 1122): virtual bool SecurityService::OnAppInitializing(Tizen::App::AppRegistry&)(102) > Channel IPC Server init started... VCONF_APPSERVICE_STATUS = 0
01-01 10:00:46.120 I/osp-security-service( 1122): virtual bool SecurityService::OnAppInitializing(Tizen::App::AppRegistry&)(118) > Channel Service has not been launched. Wait for launching channel service.
01-01 10:00:46.120 I/osp-security-service( 1122): virtual bool SecurityService::OnAppInitializing(Tizen::App::AppRegistry&)(123) > Exit
01-01 10:00:46.120 I/osp-security-service( 1122): virtual bool SecurityService::OnAppInitialized()(141) > Enter
01-01 10:00:46.130 I/osp-security-service( 1122): virtual bool SecurityService::OnAppInitialized()(150) > Exit
01-01 10:00:46.210 E/Tizen::App( 1035): static result Tizen::App::_ConditionDatabaseHelper::GetAllSectionsFromConditionDb(Tizen::Base::Collection::ArrayList*)(639) > [E_SUCCESS] No record exists in database.
01-01 10:00:46.235 I/osp-security-service( 1122): static void SecurityService::OnChannelServiceLaunched(keynode_t*, void*)(199) > OnChannelServiceLaunched started. - vconf changed.
01-01 10:00:46.235 I/osp-security-service( 1122): static void SecurityService::OnChannelServiceLaunched(keynode_t*, void*)(208) > Channel Service launched. DRM IPC Server will be started.
01-01 10:00:46.235 I/osp-security-service( 1122): result DrmService::Construct()(102) > DrmService::Construct is called.
01-01 10:00:46.245 I/osp-security-service( 1122): result DrmService::Construct()(107) > DrmService::RequestLocalMessagePort successfully called.
01-01 10:00:46.245 I/osp-security-service( 1122): result DrmService::Construct()(112) > DrmService : LocalMessagePort is ready.
01-01 10:00:46.245 I/osp-security-service( 1122): static DrmService* DrmService::GetInstance()(79) > DrmService : m_pInstance is created.
01-01 10:00:46.245 I/osp-security-service( 1122): static void SecurityService::OnChannelServiceLaunched(keynode_t*, void*)(213) > DRM IPC Server succesfully launched.
01-01 10:00:46.545 E/Tizen::Base::Runtime( 1182): static Tizen::Base::Runtime::_EventManager* Tizen::Base::Runtime::_EventManager::GetCurrentEventManager()(292) > [E_OBJ_NOT_FOUND] This is not OSP thread.
01-01 10:00:46.545 E/Tizen::Base::Runtime( 1182): result Tizen::Base::Runtime::_Event::Initialize()(207) > [E_INVALID_OPERATION] Event manager does not exist.
01-01 10:00:46.715 E/osp-app-service( 1035): result Tizen::Base::Collection::__LinkedListEnumeratorT<Type>::MoveNext() [with Type = Tizen::Base::Runtime::_Event::_ListenerInfo, result = long unsigned int](1466) > [E_INVALID_OPERATION] The source collection is modified after the creation of this enumerator.
01-01 10:00:48.195 E/Tizen::Io( 1124): result Tizen::Io::_IpcClient::MakeConnection(bool)(205) > [E_SYSTEM] Failed to connect to server(/var/run/osp/osp.sys.ipcserver.setting_service) : No such file or directory
01-01 10:00:48.195 E/Tizen::Io( 1124): result Tizen::Io::_IpcClient::Construct(const Tizen::Base::String&, const Tizen::Io::_IIpcClientEventListener*)(103) > [E_SYSTEM] Failed to connect to server.
01-01 10:00:48.195 E/Tizen::System( 1124): result Tizen::System::_SettingClient::Construct()(248) > [E_SYSTEM] It is failed to construct IPC client.
01-01 10:00:48.195 E/Tizen::System( 1124): static void Tizen::System::_SettingClient::InitSettingClient()(179) > It is failed to create SettingClient by [E_SYSTEM].
01-01 10:00:48.195 E/Tizen::System( 1124): static result Tizen::System::_SettingInfoImpl::AddSettingEventListenerForInternal(Tizen::System::ISettingEventListener&)(373) > [E_SYSTEM] It is failed to intialize setting manager
01-01 10:00:48.450 E/Tizen::System( 1124): void CommonService::InitializeServices()(101) > Setting done
01-01 10:00:48.450 E/Tizen::System( 1124): void CommonService::InitializeServices()(103) > Runtime done
01-01 10:00:48.455 E/Tizen::System( 1124): void CommonService::InitializeServices()(105) > Device done
01-01 10:00:48.460 E/Tizen::System( 1124): void CommonService::InitializeServices()(107) > Power done
01-01 10:00:48.460 E/Tizen::System( 1124): void CommonService::InitializeServices()(116) > UI done
01-01 10:00:48.460 E/Tizen::System( 1124): void CommonService::InitializeServices()(123) > Message done
01-01 10:00:48.460 E/Tizen::System( 1124): void CommonService::InitializeServices()(126) > System done
01-01 10:00:48.460 E/Tizen::System( 1124): void CommonService::InitializeServices()(129) > AlarmEx done
01-01 10:00:48.965 E/Tizen::Net::Nfc( 1182): result NfcService::Construct()(77) > [E_UNSUPPORTED_OPERATION] NFC is not supported.
01-01 10:00:48.965 E/Tizen::Net::Nfc( 1182): result NfcConnectivityIpcStub::Construct()(67) > [E_UNSUPPORTED_OPERATION] Failed to construct NfcService.
01-01 10:00:48.970 E/Tizen::Net::Bluetooth( 1182): result BluetoothService::Construct()(61) > [E_UNSUPPORTED_OPERATION] Bluetooth is not supported.
01-01 10:00:48.970 E/Tizen::Net::Bluetooth( 1182): result BluetoothConnectivityIpcStub::Construct()(67) > [E_UNSUPPORTED_OPERATION] Failed to construct BluetoothService.
01-01 10:00:51.725 E/Tizen::System( 1124): static result Tizen::System::_PowerManager::ChangeBrightness(int)(48) > [E_SYSTEM] It failed to get the device max brightness
12-05 00:01:33.325 E/Tizen::Base::Runtime( 1683): static Tizen::Base::Runtime::_EventManager* Tizen::Base::Runtime::_EventManager::GetCurrentEventManager()(292) > [E_OBJ_NOT_FOUND] This is not OSP thread.
12-05 00:01:33.325 E/Tizen::Base::Runtime( 1683): result Tizen::Base::Runtime::_Event::Initialize()(207) > [E_INVALID_OPERATION] Event manager does not exist.
12-05 00:01:33.345 I/osp-installer( 1683): int main(int, char**)(72) >  # argv[0] = [/usr/etc/package-manager/backend/tpk]
12-05 00:01:33.345 I/osp-installer( 1683): int main(int, char**)(72) >  # argv[1] = [-k]
12-05 00:01:33.345 I/osp-installer( 1683): int main(int, char**)(72) >  # argv[2] = [/opt/usr/apps/tmp/aRVivWqLcY-2.0.0-arm.tpk_-1337053426]
12-05 00:01:33.345 I/osp-installer( 1683): int main(int, char**)(72) >  # argv[3] = [-i]
12-05 00:01:33.345 I/osp-installer( 1683): int main(int, char**)(72) >  # argv[4] = [/opt/usr/apps/tmp/aRVivWqLcY-2.0.0-arm.tpk]
12-05 00:01:33.345 I/osp-installer( 1683): int main(int, char**)(72) >  # argv[5] = [-q]
12-05 00:01:33.345 I/osp-installer( 1683): int main(int, char**)(161) >  # path = [/opt/usr/apps/tmp/aRVivWqLcY-2.0.0-arm.tpk]
12-05 00:01:33.350 I/        ( 1683): bool Tizen::App::Package::_PackageParser::OnDisplayNameValue(const char*)(1021) > It's display name for UiApp, ServiceApp
12-05 00:01:33.350 I/        ( 1683): bool Tizen::App::Package::_PackageParser::OnDisplayNamesEndElement()(759) > It's display name for UiApp, ServiceApp
12-05 00:01:33.350 I/        ( 1683): bool Tizen::App::Package::_PackageParser::OnIconValue(const char*)(903) > It's icon value for UiApp, ServiceApp
12-05 00:01:33.360 I/osp-installer( 1683): int main(int, char**)(205) >  # path = [/opt/usr/apps/tmp/aRVivWqLcY-2.0.0-arm.tpk] -> optionalData = [aRVivWqLcY]
12-05 00:01:33.360 I/osp-installer( 1683): InstallerError InstallerManager::Construct(const Tizen::Base::String&, InstallerOperation, InstallerOption, void*, const Tizen::Base::String*)(145) > ------------------------------------------
12-05 00:01:33.360 I/osp-installer( 1683): InstallerError InstallerManager::Construct(const Tizen::Base::String&, InstallerOperation, InstallerOption, void*, const Tizen::Base::String*)(146) > InstallerManager
12-05 00:01:33.360 I/osp-installer( 1683): InstallerError InstallerManager::Construct(const Tizen::Base::String&, InstallerOperation, InstallerOption, void*, const Tizen::Base::String*)(147) > ------------------------------------------
12-05 00:01:33.360 I/osp-installer( 1683): InstallerError InstallerManager::Construct(const Tizen::Base::String&, InstallerOperation, InstallerOption, void*, const Tizen::Base::String*)(148) >  # operation = [Install]
12-05 00:01:33.360 I/osp-installer( 1683): InstallerError InstallerManager::Construct(const Tizen::Base::String&, InstallerOperation, InstallerOption, void*, const Tizen::Base::String*)(149) >  # path      = [/opt/usr/apps/tmp/aRVivWqLcY-2.0.0-arm.tpk]
12-05 00:01:33.360 I/osp-installer( 1683): InstallerError InstallerManager::Construct(const Tizen::Base::String&, InstallerOperation, InstallerOption, void*, const Tizen::Base::String*)(150) > ------------------------------------------
12-05 00:01:33.360 I/osp-installer( 1683): bool InstallerManager::ParseOptionalData(const Tizen::Base::String*)(482) >  # optionalData = [aRVivWqLcY]
12-05 00:01:33.360 I/osp-installer( 1683): bool InstallerManager::ParseOptionalData(const Tizen::Base::String*)(489) >  # package = [aRVivWqLcY]
12-05 00:01:33.360 I/osp-installer( 1683): static Tizen::Base::Collection::IMap* InstallerUtil::ParseN(const Tizen::Base::String&, const Tizen::Base::String&)(1040) > token = [aRVivWqLcY]
12-05 00:01:33.360 I/osp-installer( 1683): static Tizen::Base::Collection::IMap* InstallerUtil::ParseN(const Tizen::Base::String&, const Tizen::Base::String&)(1046) > '=' is not existed.
12-05 00:01:33.360 I/osp-installer( 1683): static Tizen::Base::Collection::IMap* InstallerUtil::ParseN(const Tizen::Base::String&, const Tizen::Base::String&)(1066) > pMap->GetCount() is invalid.
12-05 00:01:33.370 I/osp-installer( 1683): static bool InstallerManager::SendEvent(void*, const Tizen::App::PackageId&, const Tizen::Base::String&, const Tizen::Base::String&)(1042) > pkgmgr_installer_send_signal(tpk, aRVivWqLcY, start, install)
12-05 00:01:33.380 I/osp-installer( 1683): static bool InstallerUtil::CreateFlagFile(const Tizen::Base::String&)(595) > CreateFlagFile(), filePath = [/opt/share/packages/.recovery/tpk/aRVivWqLcY]
12-05 00:01:33.380 I/osp-installer( 1683): Installer* InstallerManager::CreateInstaller(InstallerType)(290) > InstallerType = [PackageInstaller]
12-05 00:01:33.385 I/osp-installer( 1683): bool SmackManager::Begin()(312) > [smack] perm_begin()
12-05 00:01:33.410 I/osp-installer( 1683): bool SmackManager::Begin()(314) > [smack] perm_begin(), result = [0]
12-05 00:01:33.410 I/osp-installer( 1683): static bool InstallerManager::SendEvent(void*, const Tizen::App::PackageId&, const Tizen::Base::String&, const Tizen::Base::String&)(1042) > pkgmgr_installer_send_signal(tpk, aRVivWqLcY, install_percent, 0)
12-05 00:01:33.410 I/osp-installer( 1683): virtual InstallerError Installer::OnInit()(96) > Installer::OnInit()
12-05 00:01:33.410 I/osp-installer( 1683): virtual InstallerError PackageCheckStep::Run(InstallationContext*)(47) >  PackageCheckStep - START
12-05 00:01:33.410 I/osp-installer( 1683): virtual InstallerError PackageCheckStep::Run(InstallationContext*)(56) > [STATE_PACKAGE_CHECK]
12-05 00:01:33.435 I/osp-installer( 1683): static bool InstallerUtil::IsDrmFile(const Tizen::Base::String&)(424) > [drm] drm_oem_sapps_is_drm_file(/opt/usr/apps/tmp/aRVivWqLcY-2.0.0-arm.tpk, 42)
12-05 00:01:33.435 I/osp-installer( 1683): static bool InstallerUtil::IsDrmFile(const Tizen::Base::String&)(426) > [drm] drm_oem_sapps_is_drm_file(), result = [1600]
12-05 00:01:33.440 I/osp-installer( 1683): InstallerError PackageCheckStep::OnStatePackageCheck()(138) > UnzipTo(manifest.xml) - START
12-05 00:01:33.445 I/osp-installer( 1683): InstallerError PackageCheckStep::OnStatePackageCheck()(149) > UnzipTo(manifest.xml) - END
12-05 00:01:33.445 I/osp-installer( 1683): virtual InstallerError PackageCheckStep::Run(InstallationContext*)(61) > [STATE_DONE]
12-05 00:01:33.445 I/osp-installer( 1683): virtual InstallerError PackageCheckStep::Run(InstallationContext*)(76) >  PackageCheckStep - END
12-05 00:01:33.445 I/osp-installer( 1683): virtual InstallerError DrmStep::Run(InstallationContext*)(66) > [STATE_DONE]
12-05 00:01:33.445 I/osp-installer( 1683): virtual InstallerError ManifestXmlStep::Run(InstallationContext*)(50) > ------------------------------------------
12-05 00:01:33.445 I/osp-installer( 1683): virtual InstallerError ManifestXmlStep::Run(InstallationContext*)(51) >  ManifestXmlStep - START
12-05 00:01:33.445 I/osp-installer( 1683): virtual InstallerError ManifestXmlStep::Run(InstallationContext*)(52) > ------------------------------------------
12-05 00:01:33.445 I/osp-installer( 1683): virtual InstallerError ManifestXmlStep::Run(InstallationContext*)(61) > [STATE_MANIFEST]
12-05 00:01:33.445 I/osp-installer( 1683): InstallerError ManifestXmlStep::OnStateManifestXml()(123) > manifest file=[/opt/usr/apps/__@@osp_tmp@@__/info/manifest.xml]
12-05 00:01:33.445 I/osp-installer( 1683): virtual bool ManifestHandler::OnStartElement(const char*)(106) > ------------------------------------------
12-05 00:01:33.445 I/osp-installer( 1683): virtual bool ManifestHandler::OnStartElement(const char*)(107) > manifest.xml
12-05 00:01:33.445 I/osp-installer( 1683): virtual bool ManifestHandler::OnStartElement(const char*)(108) > ------------------------------------------
12-05 00:01:33.445 I/osp-installer( 1683): virtual bool ManifestHandler::OnStartElement(const char*)(109) > <Manifest>
12-05 00:01:33.445 I/osp-installer( 1683): bool ManifestHandler::OnIdValue(const char*)(917) > <Package>aRVivWqLcY</Package>
12-05 00:01:33.445 I/osp-installer( 1683): bool ManifestHandler::OnIdValue(const char*)(933) > input package = [aRVivWqLcY], manifest = [aRVivWqLcY] is the same.
12-05 00:01:33.445 I/osp-installer( 1683): bool ManifestHandler::OnVersionValue(const char*)(949) > <Version>2.0.0</Version>
12-05 00:01:33.445 I/osp-installer( 1683): bool ManifestHandler::OnTypeValue(const char*)(958) > <Type>C++App</Type>
12-05 00:01:33.445 I/osp-installer( 1683): virtual bool ManifestHandler::OnStartElement(const char*)(113) > <Apps>
12-05 00:01:33.445 I/osp-installer( 1683): bool ManifestHandler::OnApiVersionValue(const char*)(990) > <ApiVersion>2.1</ApiVersion>
12-05 00:01:33.445 I/osp-installer( 1683): bool ManifestHandler::OnPrivilegesStartElement()(367) > <Privileges>
12-05 00:01:33.445 I/osp-installer( 1683): bool ManifestHandler::OnPrivilegeValue(const char*)(1022) > <Privilege>http://tizen.org/privilege/web.service</Privilege>
12-05 00:01:33.445 I/osp-installer( 1683): bool ManifestHandler::OnPrivilegesEndElement()(743) > </Privileges>
12-05 00:01:33.445 I/osp-installer( 1683): bool ManifestHandler::OnUiAppStartElement()(381) > <UiApp>
12-05 00:01:33.445 I/osp-installer( 1683): bool ManifestHandler::ParseAppAttribute(XmlAttribute*, bool)(1397) >  - Name=TizenCCTV
12-05 00:01:33.445 I/osp-installer( 1683): bool 
End of latest debug message
