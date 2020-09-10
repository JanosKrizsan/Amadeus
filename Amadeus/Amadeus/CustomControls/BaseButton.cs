using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Amadeus.CustomControls
{
    public class BaseButton : Button
    {
        public BaseButton(ComponentResourceManager res, string name, int tabIndex = default, Color backColor = default, Point point = default, Padding margin = default, Size size = default, string text = default, DockStyle dock = default, AnchorStyles anchor = default, FlatStyle flat = default, bool visStyleBackColor = default)
        {
            BackColor = backColor;
            Location = point;
            Margin = margin;
            Size = size;
            Text = text;
            Dock = dock;
            FlatStyle = flat;
            Anchor = anchor;
            TabIndex = tabIndex;
            Name = name;
            UseVisualStyleBackColor = visStyleBackColor;
            res.ApplyResources(this, name);
        }
    }
}
