using System;
using System.Windows.Input;
using Prism.Navigation;
using UITestSample.Views;
using Xamarin.Forms;

namespace UITestSample.ViewModels
{
    public class ButtonViewModel : BaseViewModel
    {
        public ButtonViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }

        public ICommand GoToListPage => new Command(() => NavigationService.NavigateAsync(nameof(ListPage)));
    }
}
