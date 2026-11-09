namespace InnerNet
{
    public class InnerNetServer : DestroyableSingleton
    {
        public int HostId;
        public PlatformSpecificData PlatformData;
        public int Port;
        public InnerNet.GameStates GameState;
        public Hazel.Udp.UdpConnectionListener listener;
    }
}
