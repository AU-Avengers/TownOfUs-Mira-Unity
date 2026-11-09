namespace InnerNet
{
    public struct GameListing
    {
        public System.UInt32 IP;
        public System.UInt16 Port;
        public int GameId;
        public System.Byte PlayerCount;
        public string HostName;
        public string HostPlatformName;
        public Platforms Platform;
        public int Age;
        public int MaxPlayers;
        public int NumImpostors;
        public System.Byte MapId;
        public System.UInt32 Language;
    }
}
