using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestSample.UITests
{
    public class AppInitializer
    {
        //Android
        private static string _apkPath = "../../../UITestSample.Android/bin/Debug/com.companyname.uitestsample.apk";

        //iOS
        private static string _bundlePath = "../../../UITestSample.iOS/bin/iPhoneSimulator/Debug/device-builds/iphone 11-13.3/UITestSample.iOS.app";
        private static string _bundleId = "com.companyname.UITestSample";
        private static string _deviceId = "E81A8C69-9FBF-43B9-9CED-3B06C88849F4";

        private static IApp _app;
        public static IApp App
        {
            get
            {
                if (_app == null)
                {
                    throw new NullReferenceException("The App is null. Call AppInitializer.StartApp before calling App.");
                }

                return _app;
            }
        }

        private static Platform? _platform;
        public static Platform Platform
        {
            get
            {
                if (_platform == null)
                {
                    throw new NullReferenceException("The Platform is not set.");
                }

                return _platform.Value;
            }

            set { _platform = value; }
        }

        public static void StartApp()
        {
            if (Platform == null)
            {
                throw new Exception("Platforms is not set");
            }

            if (Platform == Platform.Android)
            {
                _app = ConfigureApp
                      .Android
                      .ApkFile(_apkPath)
                      .StartApp();
            }

            _app = ConfigureApp
                  .iOS
                  .AppBundle(_bundlePath) //to launch tests on simulator
                                          //.InstalledApp(_bundleId) //to launch tests on real device
                  .DeviceIdentifier(_deviceId) //to specify runnable device
                  .StartApp();
        }
    }
}