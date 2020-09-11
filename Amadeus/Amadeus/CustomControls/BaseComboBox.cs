using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.CustomControls
{
    public class BaseComboBox : ComboBox
    {
        public BaseComboBox(ComponentResourceManager res, string name, int tabIndex = default, Point point = default, Size size = default, Padding padding = default)
        {
            Name = name;
            TabIndex = tabIndex;
            Location = point;
            Size = size;
            Margin = padding;
            res.ApplyResources(this, name);
        }
    }
}
