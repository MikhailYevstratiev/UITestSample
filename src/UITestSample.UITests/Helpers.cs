using System;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITestSample.UITests
{
    public static class Helpers
    {
        private static IApp App
        {
            get => AppInitializer.App;
        }

        public static void ScrollDownToElement(Query query, int numberAttempts = 5, int timeoutSeconds = 5)
        {
            for (int i = 0; i < numberAttempts; i++)
            {                
                try
                {
                    App.WaitForElement(query, timeout: TimeSpan.FromSeconds(timeoutSeconds));
                    break;
                }
                catch (Exception ex)
                {
                    App.DragCoordinates(200, 500, 200, 100);
                }
            }
        }
    }
}
