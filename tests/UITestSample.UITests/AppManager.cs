using System;
using Xamarin.UITest;

namespace UITestSample.UITests
{
    public static class AppManager
    {
        private const string _apkPath = "../../../../src/UITestSample.Android/bin/Release/com.companyname.uitestsample.apk";
        private const string _bundlePath = "../../../../src/UITestSample.iOS/bin/iPhoneSimulator/Debug/device-builds/iphone 11-13.3/UITestSample.iOS.app";
        private const string _bundleId = "com.companyname.UITestSample";
        private const string _deviceId = "E81A8C69-9FBF-43B9-9CED-3B06C88849F4";

        #region -- Public properties --

        private static IApp app;
        public static IApp App
        {
            get
            {
                if (app == null)
                {
                    throw new NullReferenceException("'AppManager.App' not set. Call 'AppManager.StartApp()' before trying to access it.");
                }

                return app;
            }
        }

        private static Platform? platform;
        public static Platform Platform
        {
            get
            {
                if (platform == null)
                {
                    throw new NullReferenceException("'AppManager.Platform' not set.");
                }

                return platform.Value;
            }

            set
            {
                platform = value;
            }
        }

        #endregion

        #region -- Public helpers --

        public static void StartApp()
        {
            if (Platform == Platform.Android)
            {
                app = ConfigureApp
                    .Android
                    // Used to run a .apk file:
                    .ApkFile(_apkPath)
                    .StartApp();
            }
            else if (Platform == Platform.iOS)
            {
                app = ConfigureApp
                    .iOS
                    // Used to run a .app file on an ios simulator:
                    .AppBundle(_bundlePath)
                    .DeviceIdentifier(_deviceId)
                    // Used to run a .ipa file on a physical ios device:
                    //.InstalledApp(_bundleId)
                    .StartApp();
            }
        }

        #endregion
    }
}
