using System;
namespace UITestSample.Views
{
    public interface IAppearingAware
    {
        void OnAppearing();
        void OnDisappearing();
    }
}
