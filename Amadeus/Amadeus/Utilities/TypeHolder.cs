using System.Collections.Generic;

namespace Amadeus.Utilities
{
    public class TypeHolder
    {
        public static TypeHolder Instance { get { return _instance.Value; } }
        private static readonly Lazy<TypeHolder> _instance = new Lazy<TypeHolder>(() => new TypeHolder());
        public Dictionary<string, string> Folders { get; private set; }
        public Dictionary<string, string> Files { get; private set; }
        public Dictionary<string, string> Items { get; private set; }

        private TypeHolder()
        {
            Folders = new Dictionary<string, string>()
            {
                { "User", "\\User_Data" },
                { "Script", "\\Scripts_Saved" },
                { "Object", "\\Results_Saved" },
                { "Report", "\\Reports_Saved" }
            };
            Files = new Dictionary<string, string>()
            {
                { "XML", ".xml" },
                { "CSV", ".csv" },
                { "RDP", ".rdp" },
                { "TXT", ".txt" },
                { "PS", ".ps1" }
            };
            Items = new Dictionary<string, string>()
            {
                { "RDP", "rdp_" },
                { "VPN", "vpn_" },
                { "IP", "ip_" },
                { "PROXY", "proxy_" },
                { "MAC", "mac_" },
                { "REPORT", "report_" },
                { "SCRIPT", "script_" }
            };

        }
    }


}
