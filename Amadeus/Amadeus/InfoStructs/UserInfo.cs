namespace Amadeus.InfoStructs
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public string PassHash { get; set; }
        public string PGPKey { get; set; }
        public string EMailAddress { get; set; }
        public int MyProperty { get; set; }
        public UserSettings SavedSettings { get; set; }

    }
    public class UserSettings
    {
        public bool AutoLogin { get; set; }
        public bool DoNotSaveData { get; set; }
        public bool WipeDataOnQuit { get; set; }
        public bool ResetToSysDefOnQ { get; set; }
        public bool AlwaysPGP { get; set; }
        public bool EmailReports { get; set; }
        public bool ForcePGPInMail { get; set; }
    }
}
