using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UITestSample.Views
{
    public partial class ButtonView : BaseContentPage
    {
        public ButtonView()
        {
            InitializeComponent();
            var button = new Button();
            button1.Command = new Command(OnButtonTapped);
        }

        private void OnButtonTapped()
        {
            button1.TextColor = Color.White;
            if (button1.BackgroundColor == Color.Red)
            {
                button1.BackgroundColor = Color.Green;
            }
            else
            {
                button1.BackgroundColor = Color.Red;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
