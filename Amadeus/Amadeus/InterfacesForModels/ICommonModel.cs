using System.Collections.Generic;

namespace Amadeus.InterfacesForModels
{
    interface ICommonModel
    {
        /// <summary>
        /// Retrieves the collected data for the Form
        /// </summary>
        /// <returns>Dictionary of names and object data</returns>
        Dictionary<string, object> GetFormData();

        /// <summary>
        /// Fills the FormData of the specific Form
        /// </summary>
        /// <param name="dataKeys">Controls' names on the Form</param>
        void FillFormData(string[] dataKeys);

        /// <summary>
        /// Updates or Adds a specific value
        /// </summary>
        /// <param name="key">Key to search by</param>
        /// <param name="value">Value to assign as new</param>
        void UpdateOrAddFormData(string key, object value);

        /// <summary>
        /// Removes a specific Form key-value pair
        /// </summary>
        /// <param name="key">Key to remove by</param>
        void RemoveFormData(string key);

        /// <summary>
        /// Clears all Form Data
        /// </summary>
        void ClearFormData();
    }
}
