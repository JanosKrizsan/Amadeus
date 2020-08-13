using Amadeus.InterfacesForModels;

namespace Amadeus.Models
{
    class LoginModel : CommonModel, ILoginMod
    {
        public LoginModel(string[] ctrlInfo) : base(ctrlInfo)
        {
        }
        public override void FillFormData(string[] dataKeys)
        {
        }
    }
}
