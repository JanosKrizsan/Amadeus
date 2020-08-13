namespace Amadeus.Utilities
{
    //TODO -> Possibly change to struct, but might not be needed
    public enum ItemTypes
    {
        USER,
        SCRIPT,
        OBJECT,
        REPORT
    }

    public enum SaveTypes
    {
        XML,
        CSV,
        RDP,
        TXT
    }

    public enum ObjectTypes
    {
        RDP,
        VPN,
        IP,
        PROXY,
        MAC
    }

    /// <summary>
    /// Converts enum values to required strings
    /// </summary>
    public static class EnumsHelper
    {
        public static string EnumToString(dynamic enumChild)
        {
            var enumPlacement = (int)enumChild;
            if (enumChild.GetType() == typeof(ItemTypes))
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
            else if (enumChild.GetType() == typeof(SaveTypes))
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
                    default:
                        return "";
                }
            }
            else
            {
                switch (enumPlacement)
                {
                    case 0:
                        return "rdp_obj";
                    case 1:
                        return "vpn_obj";
                    case 2:
                        return "ip_obj";
                    case 3:
                        return "proxy_obj";
                    case 4:
                        return "mac_obj";
                    default:
                        return "";
                }
            }
        }
    }

}
