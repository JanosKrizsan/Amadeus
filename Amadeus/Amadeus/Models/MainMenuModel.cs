using Amadeus.Forms;
using Amadeus.InterfacesForModels;

namespace Amadeus.Models
{
    class MainMenuModel : CommonModel, IMainMenuMod
    {
        public MainMenuModel(string[] ctrlInfo) : base(ctrlInfo)
        {
        }

        public override void FillFormData(string[] dataKeys)
        {
        }
    }
}
