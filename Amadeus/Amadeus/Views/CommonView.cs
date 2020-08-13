using Amadeus.InterfacesForViews;
using System.Windows.Forms;
using System.Linq;

namespace Amadeus.Views
{
    abstract class CommonView : ICommonView
    {
        /// <summary>
        /// The View's corresponding Form
        /// </summary>
        internal Form _form;

        public CommonView(Form form)
        {
            _form = form;
            SubToEvents();
        }
        public void ShowForm()
        {
            _form.ShowDialog();
        }
        public void CloseForm()
        {
            _form.Close();
        }
        public string[] GetFormControlNames()
        {
            var panels = _form.Controls.Cast<Control>().Where(p => p.GetType() == typeof(Panel));
            var nonPanelsNonLabels = panels.Where(c => c.GetType() != typeof(Panel) && c.GetType() != typeof(Label));
            return nonPanelsNonLabels.Select(c => c.Name).ToArray();
        }

        public abstract void OnLoadCheck();
        public abstract void SetViewControls();
        public abstract void SubToEvents();

    }
}
