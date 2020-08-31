using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus.CustomControls
{
    public class BaseLabel : Label
    {
        private Font _default = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        public BaseLabel(ComponentResourceManager res, string name, int tabIndex, Point point, Size size, string text, Font font = null)
        {

            Location = point;
            Size = size;
            Name = name;
            TabIndex = tabIndex;
            Text = text;
            Font = font ?? _default;
            res.ApplyResources(this, name);
        }
    }
}
