using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.CustomControls
{
    class BaseListBox : ListBox
    {
        public BaseListBox(ComponentResourceManager res, string name, int tabIndex = default, bool formatting = default, bool scrollAlwaysVisible = default, Color backColor = default, Color foreColor = default, Point point = default, Size size = default, int itemHeight = default, SelectionMode selMode = default)
        {
            Name = name;
            FormattingEnabled = formatting;
            ScrollAlwaysVisible = scrollAlwaysVisible;
            TabIndex = tabIndex;
            BackColor = backColor;
            ForeColor = foreColor;
            Location = point;
            Size = size;
            ItemHeight = itemHeight;
            SelectionMode = selMode;
            res.ApplyResources(this, name);
        }
    }
}
