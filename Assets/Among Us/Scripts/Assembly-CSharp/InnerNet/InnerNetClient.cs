namespace InnerNet
{
    public class InnerNetClient : UnityEngine.MonoBehaviour
    {
        public float MinSendInterval;
        public System.UInt32 NetIdCnt;
        public float timer;
        public InnerNet.InnerNetObject[] NonAddressableSpawnableObjects;
        public bool InOnlineScene;
        public Hazel.MessageWriter[] Streams;
        public int msgNum;
        public Logger serverLogger;
        public string networkAddress;
        public int networkPort;
        public bool useDtls;
        public Hazel.Udp.UnityUdpClientConnection connection;
        public InnerNet.MatchMakerModes mode;
        public NetworkModes NetworkMode;
        public int GameId;
        public int HostId;
        public int ClientId;
        public DisconnectReasons LastDisconnectReason;
        public string LastCustomDisconnect;
        public System.Byte LastServerChatMode;
        public HttpMatchmakerManager.MatchmakerError LastMatchmakerError;
        public AmongUs.GameOptions.GameOptionsFactory gameOptionsFactory;
        public InnerNet.InnerNetClient.GameStates GameState;
        public bool isConnecting;
        public bool platformSpecificsChecked;
        public enum GameStates : int
        {
            NotJoined = 0,
            Joined = 1,
            Started = 2,
            Ended = 3,
}
    }
}
