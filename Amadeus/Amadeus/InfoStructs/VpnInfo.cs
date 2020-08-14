namespace Amadeus.InfoStructs
{
    public struct VpnInfo
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string TunnelType { get; set; }
        public string EncryptionLevel { get; set; }
        public string AuthMethod { get; set; }
        public bool SplitTunnel { get; set; }
        public bool AvailForAllUsers { get; set; }
    }
}
