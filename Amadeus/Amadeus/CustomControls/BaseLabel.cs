using System.ComponentModel;
using FontType = System.Drawing.Font;
using Location = System.Drawing.Point;
using Size = System.Drawing.Size;
using System.Windows.Forms;

namespace Amadeus.CustomControls
{
    public class BaseLabel : Label
    {
        private FontType _default = new FontType("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        public BaseLabel(ComponentResourceManager res, bool autoSize, Location loc, Size size, string name, int tabIndex, string text, FontType font = null)
        {

            AutoSize = autoSize;
            Location = loc;
            Size = size;
            Name = name;
            TabIndex = tabIndex;
            Text = "Selected\'s Info:";
            Font = font ?? _default;
            res.ApplyResources(this, name);
        }
    }
}
