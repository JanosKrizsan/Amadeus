using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.CustomControls
{
    public class BaseCheckBox : CheckBox
    {
        public BaseCheckBox(ComponentResourceManager res, string name, bool visStyleBackColor, string text, ContentAlignment alignText, ContentAlignment alignBox)
        {
            res.ApplyResources(this, name);
            Name = name;
            UseVisualStyleBackColor = visStyleBackColor;
            Text = text;
            TextAlign = alignText;
            CheckAlign = alignBox;
        }
    }
}
