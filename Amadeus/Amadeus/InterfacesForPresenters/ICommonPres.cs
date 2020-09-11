using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForViews;

namespace Amadeus.InterfacesForPresenters
{
    interface ICommonPres
    {
        /// <summary>
        /// Shows the View
        /// </summary>
        void ShowView();

        /// <summary>
        /// Closes the View
        /// </summary>
        void CloseView();

        /// <summary>
        /// Gets the names of the View's Form's Controllers.
        /// </summary>
        void GetViewInfo();

    }
}
