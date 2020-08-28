using System.ComponentModel;
using System.Windows.Forms;

namespace Amadeus.CustomControls
{
    public class BasePanel : Panel
    {
        public BasePanel(ComponentResourceManager res, string name, Control[] controllers)
        {
            res.ApplyResources(this, name);
            Name = name;
            foreach (var ctrl in controllers)
            {
                Controls.Add(ctrl);
            }
        }
    }
}
