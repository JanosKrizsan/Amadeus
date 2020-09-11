using Amadeus.Forms;
using Amadeus.InterfacesForModels;

namespace Amadeus.Models
{
    class MainMenuSubModel : CommonModel, IMainMenuSubMod
    {
        public MainMenuSubModel(string[] ctrlInfo) : base(ctrlInfo)
        {
        }

        public override void FillFormData(string[] dataKeys)
        {
        }
    }
}
