using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.CustomControls
{
    public class BasePanel : Panel
    {
        public BasePanel(ComponentResourceManager res, string name, Control[] controllers, Point point, Size size, int tabIndex)
        {
            Name = name;
            Location = point;
            Size = size;
            TabIndex = tabIndex;
            foreach (var ctrl in controllers)
            {
                Controls.Add(ctrl);
            }
            SuspendLayout();
            res.ApplyResources(this, name);
        }
    }
}
