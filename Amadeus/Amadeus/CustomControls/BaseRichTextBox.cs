using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;


namespace Amadeus.CustomControls
{
    class BaseRichTextBox : RichTextBox
    {
        public BaseRichTextBox(ComponentResourceManager res, string name, int tabIndex = default, Color backColor = default, Color frontColor = default, Point point = default, Size size = default, Padding margin = default)
        {
            BackColor = backColor;
            ForeColor = frontColor;
            Location = point;
            Margin = margin;
            Name = name;
            Size = size;
            TabIndex = tabIndex;
            res.ApplyResources(this, Name);
        }
    }
}
