using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using UITestSample.UITests.Pages;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestSample.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp App => AppInitializer.App;

        public Tests(Platform platform)
        {
            AppInitializer.Platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            AppInitializer.StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            App.Screenshot("First screen.");

            new ButtonPage()
                .TapColorButton()
                .TapColorButton()
                .InputText("This is a UITest")
                .TapColorButton()
                .GoToListPage();

            new ListPage()
                .TapSpecialCell();
        }
    }
}
