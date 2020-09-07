using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus.CustomControls
{
    public class BaseProgressBar : ProgressBar
    {
        public BaseProgressBar(ComponentResourceManager res, string name, int tabIndex, Point point = default, Size size = default)
        {
            Name = name;
            Location = point;
            Size = size;
            TabIndex = tabIndex;
            res.ApplyResources(this, name);
        }
    }
}
