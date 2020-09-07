using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus.CustomControls
{
    public class BaseTextBox : TextBox
    {
        public BaseTextBox(ComponentResourceManager res, string name, int tabIndex = default, Point point = default, Size size = default, Font font = default, Padding padding = default)
        {
            Name = name;
            TabIndex = tabIndex;
            Location = point;
            Size = size;
            Font = font;
            Margin = padding;
            res.ApplyResources(this, name);
        }
    }
}
