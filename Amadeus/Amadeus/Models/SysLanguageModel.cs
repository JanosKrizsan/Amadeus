using Amadeus.InterfacesForModels;

namespace Amadeus.Models
{
    class SysLangModel : CommonModel, ISysLanguageMod
    {
        public SysLangModel(string[] ctrlInfo) : base(ctrlInfo)
        {
        }

        public override void FillFormData(string[] dataKeys)
        {
        }
    }
}
