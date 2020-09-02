using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus.CustomControls
{
    class BaseFlowPanel : FlowLayoutPanel
    {
        public BaseFlowPanel(ComponentResourceManager res, Control[] controls, Point point, Size size, string name, int tabIndex, params object[] args
            )
        {
            foreach (var ctrl in controls)
            {
                Controls.Add(ctrl);
            }
            Location = point;
            Name = name;
            Size = size;
            TabIndex = tabIndex;
            BorderStyle = (BorderStyle)args[0];
            FlowDirection = (FlowDirection)args[1];
            Anchor = (AnchorStyles)args[2];
            SuspendLayout();
            res.ApplyResources(this, name);
        }
    }
}
