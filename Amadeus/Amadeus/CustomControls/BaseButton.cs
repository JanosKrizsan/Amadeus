using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Amadeus.CustomControls
{
    public class BaseButton : Button
    {
        public BaseButton(ComponentResourceManager res, string name, bool visStyleBackColor, int tabIndex = 0, params object[] args)
        {
            BackColor = (Color)args[0];
            Location = (Point)args[1];
            Margin = (Padding)args[2];
            Size = (Size)args[3];
            Text = (string)args[4];
            Dock = (DockStyle)args[5];
            TabIndex = tabIndex;
            Name = name;
            UseVisualStyleBackColor = visStyleBackColor;
            res.ApplyResources(this, name);
        }
    }
}
