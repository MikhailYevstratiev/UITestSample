using System;
using Xamarin.UITest.Queries;

//Aliases Func<AppQuery, AppQuery>
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
namespace UITestSample.UITests.Pages
{
    public class ButtonPage : BasePage
    {
        private Query _colorButton = x => x.Marked("Button1");
        private Query _navigationButton = x => x.Marked("Go to List page");
        private Query _entry = x => x.Marked("Entry1");

        public override Query Trait => x => x.Marked("Buttons Page");

        public ButtonPage()
        {
        }

        public ButtonPage InputText(string text)
        {
            App.ClearText(_entry);
            App.EnterText(_entry, text);
            App.DismissKeyboard();

            return this;
        }

        public ButtonPage TapColorButton()
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
