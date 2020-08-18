namespace Amadeus.Utilities
{
    //TODO -> Possibly change to struct, but might not be needed
    public enum FolderTypes
    {
        USER,
        SCRIPT,
        OBJECT,
        REPORT
    }

    public enum FileTypes
    {
        XML,
        CSV,
        RDP,
        TXT,
        PS1
    }

    public enum ObjectTypes
    {
        RDP,
        VPN,
        IP,
        PROXY,
        MAC,
        REPORT,
        SCRIPT
    }

    /// <summary>
    /// Converts enum values to required strings
    /// </summary>
    public static class EnumsHelper
    {
        public static string EnumToString(dynamic enumChild)
        {
            var enumPlacement = (int)enumChild;
            if (enumChild.GetType() == typeof(FolderTypes))
            {
                switch (enumPlacement)
                {
                    case 0:
                        return "\\User_Data";
                    case 1:
                        return "\\Saved_Scripts";
                    case 2:
                        return "\\Result_Objects";
                    case 3:
                        return "\\Reports";
                    default:
                        return "";
                }
            }
            else if (enumChild.GetType() == typeof(FileTypes))
            {
                switch (enumPlacement)
                {
                    case 0:
                        return ".xml";
                    case 1:
                        return ".csv";
                    case 2:
                        return ".rdp";
                    case 3:
                        return ".txt";
                    case 4:
                        return ".ps1";
                    default:
                        return "";
                }
            }
            else
            {
                switch (enumPlacement)
                {
                    case 0:
                        return "rdp_";
                    case 1:
                        return "vpn_";
                    case 2:
                        return "ip_";
                    case 3:
                        return "proxy_";
                    case 4:
                        return "mac_";
                    case 5:
                        return "report_";
                    case 6:
                        return "script_";
                    default:
                        return "";
                }
            }
        }
    }

}
