using System;
using NUnit.Framework;
using Xamarin.UITest;

//Aliases Func<AppQuery, AppQuery>
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITestSample.UITests.Pages
{
    public abstract class BasePage
    {
        protected IApp App
        {
            get
            {
                return AppInitializer.App;
            }
        }

        public abstract Query Trait { get; }

        protected BasePage()
        {
            AssertOnPage(TimeSpan.FromSeconds(30));
            App.Screenshot("On " + this.GetType().Name);
        }

        /// <summary>
        /// Verifies that the trait is still present. Defaults to no wait.
        /// </summary>
        /// <param name="timeout">Time to wait before the assertion fails</param>
        protected void AssertOnPage(TimeSpan? timeout = default(TimeSpan?))
        {
            var message = "Unable to verify on page: " + this.GetType().Name;

            if (Trait == null)
            {
                throw new NullReferenceException("The train is not set for this page");
            }

            if (timeout == null)
            {
                Assert.IsNotEmpty(App.Query(Trait), message);
            }
            else
            {
                Assert.DoesNotThrow(() => App.WaitForElement(Trait, timeout: timeout), message);
            }
        }

        /// <summary>
        /// Verifies that the trait is no longer present. Defaults to a 5 second wait.
        /// </summary>
        /// <param name="timeout">Time to wait before the assertion fails</param>
        //protected void WaitForPageToLeave(TimeSpan? timeout = default(TimeSpan?))
        //{
        //    timeout = timeout ?? TimeSpan.FromSeconds(5);
        //    var message = "Unable to verify *not* on page: " + this.GetType().Name;

        //    Assert.DoesNotThrow(() => app.WaitForNoElement(Trait.Current, timeout: timeout), message);
        //}
    }
}