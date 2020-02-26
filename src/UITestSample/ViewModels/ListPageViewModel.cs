using System;
using System.Collections.Generic;
using System.Windows.Input;
using Prism.Navigation;
using UITestSample.Views;
using Xamarin.Forms;

namespace UITestSample.ViewModels
{
    public class ListPageViewModel : BaseViewModel
    {
        public ListPageViewModel(INavigationService navigationService)
            : base (navigationService)
        {
            ItemTappedCommand = new Command<string>(OnItemTappedCommandAsync);
        }

        #region -- Public properties -- 

        private ICommand _itemTappedCommand;
        public ICommand ItemTappedCommand
        {
            get { return _itemTappedCommand; }
            set { SetProperty(ref _itemTappedCommand, value); }
        }

        public IList<string> Items => new List<string>
        {
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Special cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
            "Common cell",
        };

        #endregion

        #region -- Private helpers --

        private async void OnItemTappedCommandAsync(string cellName)
        {
            var parameters = new NavigationParameters();
            parameters.Add("CellName", cellName);
            await NavigationService.NavigateAsync(nameof(DetailView), parameters);
        }

        #endregion
    }
}
