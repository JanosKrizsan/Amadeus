namespace Amadeus.InfoStructs
{
    public struct IPInfo
    {
        public string IPAddress { get; set; }
        public string Mask { get; set; }
        public string GateWay { get; set; }
        public string DNS { get; set; }
        public bool IsStatic { get; set; }
    }
}
