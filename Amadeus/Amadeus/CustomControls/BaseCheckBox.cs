using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.CustomControls
{
    public class BaseCheckBox : CheckBox
    {
        public BaseCheckBox(ComponentResourceManager res, string name, int tabIndex = default, bool visStyleBackColor = default, string text = default, Point point = default, Size size = default, ContentAlignment alignText = default, ContentAlignment alignBox = default, Padding margin = default)
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
