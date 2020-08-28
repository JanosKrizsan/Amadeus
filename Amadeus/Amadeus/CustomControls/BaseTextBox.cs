using System.ComponentModel;
using System.Windows.Forms;

namespace Amadeus.CustomControls
{
    public class BaseTextBox : TextBox
    {
        public BaseTextBox(ComponentResourceManager res, string name)
        {
            res.ApplyResources(this, name);
            Text = string.Empty;
            Name = name;
        }
    }
}
