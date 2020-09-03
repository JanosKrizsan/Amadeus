using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus.CustomControls
{
    public class BaseRadioButton : RadioButton
    {
        public BaseRadioButton(ComponentResourceManager res, string name, string text, int tabIndex, bool autoSize, Point point, Size size, bool tabStop, bool visualStyleCol)
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
