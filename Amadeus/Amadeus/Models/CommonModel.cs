using Amadeus.InterfacesForModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amadeus.Models
{
    abstract class CommonModel : ICommonModel
    {
        /// <summary>
        /// Data to be used by the Form.
        /// </summary>
        protected Dictionary<string, object> FormData { get; set; }

        public CommonModel(string[] dataKeys)
        {
            FillFormData(dataKeys);
        }
        public void ClearFormData()
        {
            FormData.Clear();
        }

        public void RemoveFormData(string key)
        {
            FormData.Remove(key);
        }

        public void UpdateOrAddFormData(string key, object value)
        {
            if (FormData.ContainsKey(key))
            {
                FormData[key] = value;
            }
            else
            {
                FormData.Add(key, value);
            }
        }

        public Dictionary<string, object> GetFormData()
        {
            return FormData;
        }

        public abstract void FillFormData(string[] dataKeys);
    }
}
