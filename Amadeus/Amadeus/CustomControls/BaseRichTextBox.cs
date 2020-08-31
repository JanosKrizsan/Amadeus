using System.ComponentModel;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;


namespace Amadeus.CustomControls
{
    class BaseRichTextBox : RichTextBox
    {
        public BaseRichTextBox(ComponentResourceManager res, string name, int tabIndex, Color backColor, Color frontColor, Point point, Size size)
        {
            BackColor = backColor;
            ForeColor = frontColor;
            Location = point;
            Name = name;
            Size = size;
            TabIndex = tabIndex;
            res.ApplyResources(this, Name);
        }
    }
}
