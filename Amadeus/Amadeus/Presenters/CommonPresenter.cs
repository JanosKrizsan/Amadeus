using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    abstract class CommonPresenter : ICommonPres
    {
        internal ICommonModel _model;
        internal ICommonView _view;

        public void ShowView()
        {
            _view.ShowForm();
        }

        public void CloseView()
        {
            _view.CloseForm();
        }
    }
}
