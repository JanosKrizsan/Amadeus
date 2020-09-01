using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus.CustomControls
{
    public class BaseLabel : Label
    {
        public BaseLabel(ComponentResourceManager res, string name, int tabIndex, Point point, Size size, string text, Font font = default, bool autoSize = false, Padding padding = default)
        {

            Location = point;
            AutoSize = autoSize;
            Size = size;
            Margin = padding;
            Name = name;
            TabIndex = tabIndex;
            Text = text;
            Font = font;
            res.ApplyResources(this, name);
        }
    }
}
