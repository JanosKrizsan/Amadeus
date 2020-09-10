using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.CustomControls
{
    public class BasePanel : Panel
    {
        public BasePanel(ComponentResourceManager res, string name, int tabIndex = default, Control[] controls = default, Point point = default, Size size = default, Color backColor = default)
        {
            Name = name;
            Location = point;
            Size = size;
            TabIndex = tabIndex;
            BackColor = backColor;
            foreach (var ctrl in controls)
            {
                Controls.Add(ctrl);
            }
            SuspendLayout();
            res.ApplyResources(this, name);
        }
    }
}
