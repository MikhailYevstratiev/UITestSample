using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace UITestSample.Controls
{
    public class ExtendedListView : ListView
    {
        public ExtendedListView()
        {
            this.ItemTapped += (sender, e) =>
            {
                TappedCommand?.Execute(e.Item);
            };
        }

        public static BindableProperty TappedCommandProperty =
            BindableProperty.Create(nameof(TappedCommand), typeof(ICommand), typeof(ExtendedListView), null);

        public ICommand TappedCommand
        {
            get { return (ICommand)GetValue(TappedCommandProperty); }
            set { SetValue(TappedCommandProperty, value); }
        }
    }
}

