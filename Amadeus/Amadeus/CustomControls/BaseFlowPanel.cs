using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus.CustomControls
{
    class BaseFlowPanel : FlowLayoutPanel
    {
        public BaseFlowPanel(ComponentResourceManager res, string name, int tabIndex = default, Control[] controls = default, Point point = default, Size size = default, BorderStyle borderStyle = default, FlowDirection flow = default, AnchorStyles anchor = default, DockStyle dock = default)
        {
            foreach (var ctrl in controls)
            {
                Controls.Add(ctrl);
            }
            Location = point;
            Name = name;
            Size = size;
            TabIndex = tabIndex;
            BorderStyle = borderStyle;
            FlowDirection = flow;
            Anchor = anchor;
            Dock = dock;
            SuspendLayout();
            res.ApplyResources(this, name);
        }
    }
}
