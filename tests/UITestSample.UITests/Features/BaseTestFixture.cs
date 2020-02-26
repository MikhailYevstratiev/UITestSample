﻿using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace UITestSample.UITests.Features
{
    public abstract class BaseTestFixture
    {
        protected BaseTestFixture(Platform platform)
        {
            AppManager.Platform = platform;
        }

        [SetUp]
        public virtual void BeforeEachTest()
        {
            AppManager.StartApp();
        }
    }
}
