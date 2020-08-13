using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;
using System.Collections.Generic;

namespace Amadeus.Presenters
{
    abstract class CommonPresenter : ICommonPres
    {
        /// <summary>
        /// Model to be used by the Presenter
        /// </summary>
        internal ICommonModel _model;

        /// <summary>
        /// View to be used by the Presenter
        /// </summary>
        internal ICommonView _view;

        internal string[] ViewInfo { get; set; }

        public CommonPresenter(ICommonView view)
        {
            _view = view;
            GetViewInfo();
        }

        public void ShowView()
        {
            _view.ShowForm();
        }

        public void CloseView()
        {
            _view.CloseForm();
        }

        public Dictionary<string, object> GetModelData()
        {
            return _model.GetFormData();
        }
        public void GetViewInfo()
        {
            ViewInfo = _view.GetFormControlNames();
        }

    }
}
