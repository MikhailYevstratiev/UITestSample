using System;
using Prism.Mvvm;
using Xamarin.Forms;

namespace UITestSample.Views
{
    public class BaseContentPage : ContentPage
    {
        public BaseContentPage()
        {
            //ViewModelLocator.SetAutowireViewModel(this, true);
            //NavigationPage.SetHasNavigationBar(this, false);
        }

        #region -- Overrides --

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is IAppearingAware appearingAware)
            {
                appearingAware.OnAppearing();
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (BindingContext is IAppearingAware appearingAware)
            {
                appearingAware.OnDisappearing();
            }
        }

        #endregion
    }
}

