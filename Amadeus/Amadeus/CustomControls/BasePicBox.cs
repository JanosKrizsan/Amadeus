using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus.CustomControls
{
    public class BasePicBox : PictureBox
    {
        public BasePicBox(ComponentResourceManager res, string name, int tabIndex = default, Point point = default, Size size = default, bool tabStop = default)
        {
            Location = point;
            Name = name;
            Size = size;
            TabIndex = tabIndex;
            TabStop = tabStop;
            res.ApplyResources(this, name);
        }
    }
}
