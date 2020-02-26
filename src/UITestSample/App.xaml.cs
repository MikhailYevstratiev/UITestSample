using System;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using UITestSample.ViewModels;
using UITestSample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UITestSample
{
    public partial class App : PrismApplication
    {
        public App()
        {
        }

        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer)
        {
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //register pages
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<ButtonView, ButtonViewModel>();
            containerRegistry.RegisterForNavigation<ListPage, ListPageViewModel>();
            containerRegistry.RegisterForNavigation<DetailView, DetailViewModel>();
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new BaseContentPage());
            await NavigationService.NavigateAsync($"/{nameof(NavigationPage)}/{nameof(ButtonView)}");
        }
    }
}
