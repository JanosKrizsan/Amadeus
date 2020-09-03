using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus.CustomControls
{
    public class BasePicBox : PictureBox
    {
        public BasePicBox(ComponentResourceManager res, string name, Point point, Size size, int tabIndex, bool tabStop)
        {
            Location = point;
            Name = name;
            Size = size;
            TabIndex = tabIndex;
            TabStop = tabStop;
        }
    }
}
