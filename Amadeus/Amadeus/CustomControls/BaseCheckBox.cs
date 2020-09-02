using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.CustomControls
{
    public class BaseCheckBox : CheckBox
    {
        public BaseCheckBox(ComponentResourceManager res, string name, bool visStyleBackColor, string text, Point point, Size size, ContentAlignment alignText = default, ContentAlignment alignBox = default, Padding margin = default, int tabIndex = default)
        {
            Name = name;
            Location = point;
            TabIndex = tabIndex;
            Size = size;
            Margin = margin;
            UseVisualStyleBackColor = visStyleBackColor;
            Text = text;
            TextAlign = alignText;
            CheckAlign = alignBox;
            res.ApplyResources(this, name);
        }
    }
}
