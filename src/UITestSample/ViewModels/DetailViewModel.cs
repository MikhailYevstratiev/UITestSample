using System;
using Prism.Navigation;

namespace UITestSample.ViewModels
{
    public class DetailViewModel : BaseViewModel
    {
        public DetailViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }

        #region -- Public properties --

        private string _cellName;
        public string CellName
        {
            get { return _cellName; }
            set { SetProperty(ref _cellName, value); }
        }

        #endregion

        #region -- Overrides --

        public override void Initialize(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if(parameters.TryGetValue("CellName", out string cellName))
            {
                CellName = cellName;
            }
        }

        #endregion
    }
}
