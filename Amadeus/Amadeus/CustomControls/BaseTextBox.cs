using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus.CustomControls
{
    public class BaseTextBox : TextBox
    {
        public BaseTextBox(ComponentResourceManager res, string name, int tabIndex, Point point = default, Size size = default, Font font = default)
        {
            Name = name;
            TabIndex = tabIndex;
            Location = point;
            Size = size;
            Font = font;
            res.ApplyResources(this, name);
        }
    }
}
