namespace Amadeus.InterfacesForViews
{
    interface ICommonView
    {

        /// <summary>
        /// Shows the Form
        /// </summary>
        void ShowForm();

        /// <summary>
        /// Closes the Form
        /// </summary>
        void CloseForm();

        /// <summary>
        /// Checks controls and data on Loading the Form
        /// </summary>
        void OnLoadCheck();

        /// <summary>
        /// Sets up the data for the View
        /// </summary>
        void SetViewControls();

        /// <summary>
        /// Subscribes to Form Events
        /// </summary>
        void SubToEvents();

        /// <summary>
        /// Retrieves the names of Controls on a specific Form
        /// </summary>
        /// <returns>List of Control names to be used by the Presenter and Model</returns>
        string[] GetFormControlNames();
    }
}
