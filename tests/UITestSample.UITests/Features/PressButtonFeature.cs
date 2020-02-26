using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace UITestSample.UITests.Features
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public partial class PressButtonFeature : BaseTestFixture
    {
        public PressButtonFeature(Platform platform)
            : base(platform)
        {
        }
    }
}
