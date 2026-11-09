namespace InnerNet
{
    [System.Serializable]
    public class ClientData : System.Object
    {
        public int Id;
        public bool InScene;
        public bool IsReady;
        public bool HasBeenReported;
        public PlayerControl Character;
        public System.UInt32 PlayerLevel;
        public PlatformSpecificData PlatformData;
        public string PlayerName;
        public string ProductUserId;
        public string FriendCode;
        public int ColorId;
    }
}
