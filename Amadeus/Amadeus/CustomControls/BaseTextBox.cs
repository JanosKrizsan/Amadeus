using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus.CustomControls
{
    public class BaseTextBox : TextBox
    {
        private Font _defFont = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        public BaseTextBox(ComponentResourceManager res, string name, int tabIndex, Point point, Size size, Font font = null)
        {
            Name = name;
            TabIndex = tabIndex;
            Location = point;
            Size = size;
            Font = font ?? _defFont;
            res.ApplyResources(this, name);
        }
    }
}
