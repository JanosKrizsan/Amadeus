using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Amadeus.CustomControls
{
    public class BaseButton : Button
    {
        public BaseButton(ComponentResourceManager res, Color color, DialogResult dialogRes, int borderSize, string name, bool visStyleBackColor)
        {
            BackColor = color;
            DialogResult = dialogRes;
            FlatAppearance.BorderSize = borderSize;
            res.ApplyResources(this, name);
            Name = name;
            UseVisualStyleBackColor = visStyleBackColor;
        }
    }
}
