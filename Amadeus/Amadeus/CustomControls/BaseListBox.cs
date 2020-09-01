using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.CustomControls
{
    class BaseListBox : ListBox
    {
        public BaseListBox(ComponentResourceManager res, string name, bool formatting, bool scrollAlwaysVisible, int tabIndex = default, params object[] args)
        {
            Name = name;
            FormattingEnabled = formatting;
            ScrollAlwaysVisible = scrollAlwaysVisible;
            TabIndex = tabIndex;
            BackColor = (Color)args[0];
            ForeColor = (Color)args[1];
            Location = (Point)args[2];
            Size = (Size)args[3];
            ItemHeight = (int)args[4];
            SelectionMode = (SelectionMode)args[5];
            res.ApplyResources(this, name);
        }
    }
}
