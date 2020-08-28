using System.ComponentModel;
using System.Windows.Forms;

namespace Amadeus.CustomControls
{
    public class BaseComboBox : ComboBox
    {
        public BaseComboBox(ComponentResourceManager res, string name)
        {
            res.ApplyResources(this, name);
            Name = name;
        }
    }
}
