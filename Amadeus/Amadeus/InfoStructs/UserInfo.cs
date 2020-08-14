namespace Amadeus.InfoStructs
{
    public struct UserInfo
    {
        public string UserName { get; set; }
        public string PassHash { get; set; }
        public string PGPKey { get; set; }
        public string EMailAddress { get; set; }
        public int MyProperty { get; set; }
        internal UserSettings SavedSettings { get; set; }

    }
    internal struct UserSettings
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
