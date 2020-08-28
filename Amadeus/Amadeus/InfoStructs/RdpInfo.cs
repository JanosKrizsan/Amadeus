namespace Amadeus.InfoStructs
{
    public class RdpInfo
    {
        public string ConnName { get; set; }
        public string IPAddress { get; set; }
        public string Port { get; set; }
        public string Gateway { get; set; }
        public bool UseGateway { get; set; }
        public bool AsAdmin { get; set; }
        public bool EnableRemoteGuard { get; set; }
        public bool AsRestrictedAdmin { get; set; }
        public bool StartFullScreen { get; set; }
        public bool MultiMonitorMode { get; set; }
        public bool SpanMonitorsMode { get; set; }
        public short ScreenWidth { get; set; }
        public short ScreenHeight { get; set; }
    }
}
