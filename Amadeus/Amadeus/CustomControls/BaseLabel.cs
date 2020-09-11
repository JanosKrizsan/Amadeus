using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus.CustomControls
{
    public class BaseLabel : Label
    {
        public BaseLabel(ComponentResourceManager res, string name, int tabIndex = default, Point point = default, Size size = default, string text = default, Font font = default, bool autoSize = false, Padding padding = default, BorderStyle borderStyle = default)
        {

            Location = point;
            AutoSize = autoSize;
            Size = size;
            Margin = padding;
            Name = name;
            TabIndex = tabIndex;
            Text = text;
            Font = font;
            BorderStyle = borderStyle;
            res.ApplyResources(this, name);
        }
    }
}
