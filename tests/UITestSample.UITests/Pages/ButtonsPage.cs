using System;
using NUnit.Framework;
using Xamarin.UITest.Queries;

//Aliases Func<AppQuery, AppQuery>
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
namespace UITestSample.UITests.Pages
{
    public class ButtonsPage : BasePage
    {
        private Query _colorButton = x => x.Marked("Button1");
        private Query _navigationButton = x => x.Marked("Go to List page");
        private Query _entry = x => x.Marked("Entry1");

        protected override Query Trait => x => x.Marked("Buttons Page");

        public ButtonsPage()
        {
        }

        public ButtonsPage InputText(string text)
        {
            Helpers.EnterText(_entry, text);
            var button = App.Query(x => x.Marked("Button1"));
            return this;
        }

        public ButtonsPage TapColorButton()
        {
            App.Tap(_colorButton);

            return this;
        }

        public void GoToListPage()
        {
            App.Tap(_navigationButton);
        }
    }
}
