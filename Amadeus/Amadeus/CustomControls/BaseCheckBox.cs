using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.CustomControls
{
    public class BaseCheckBox : CheckBox
    {
        public BaseCheckBox(ComponentResourceManager res, string name, bool visStyleBackColor, string text, ContentAlignment alignText, ContentAlignment alignBox)
        {
            Name = name;
            UseVisualStyleBackColor = visStyleBackColor;
            Text = text;
            TextAlign = alignText;
            CheckAlign = alignBox;
            res.ApplyResources(this, name);
        }
    }
}
