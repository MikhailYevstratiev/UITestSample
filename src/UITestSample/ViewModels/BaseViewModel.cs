using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace UITestSample.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware, IInitialize
    {
        public INavigationService NavigationService { get; }
        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public virtual void Initialize(INavigationParameters parameters)
        {
        }
    }
}
