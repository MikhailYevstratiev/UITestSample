using System;
using Xamarin.UITest.Queries;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITestSample.UITests.Pages
{
    public class ListPage : BasePage
    {
        private Query _mainList => x => x.Marked("MainList");
        private Query _commonCell = x => x.Marked("MainList").Descendant().Index(3);
        private Query _specialCell = x => x.Marked("MainList").Descendant().Marked("Special cell");
        protected override Query Trait => x => x.Marked("List Page");

        public ListPage()
        {
        }

        public void TapCommonCell()
        {
            App.Tap(_commonCell);
        }

        public void TapSpecialCell()
        {
            Helpers.ScrollDownToElement(_specialCell);
            App.Tap(_specialCell);
        }
    }
}
