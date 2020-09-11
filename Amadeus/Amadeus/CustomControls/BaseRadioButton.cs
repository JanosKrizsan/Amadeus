using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus.CustomControls
{
    public class BaseRadioButton : RadioButton
    {
        public BaseRadioButton(ComponentResourceManager res, string name, int tabIndex = default, string text = default, bool autoSize = default, Point point = default, Size size = default, bool tabStop = default, bool visualStyleCol = default)
        {
            AutoSize = autoSize;
            Name = name;
            Location = point;
            Size = size;
            TabIndex = tabIndex;
            TabStop = tabStop;
            Text = text;
            UseVisualStyleBackColor = visualStyleCol;
            res.ApplyResources(this, name);
        }
    }
}
