namespace InnerNet
{
    public class InnerDiscover : DestroyableSingleton
    {
        public Hazel.Udp.UdpBroadcastListener listener;
        public Hazel.Udp.UdpBroadcaster sender;
        public int Port;
        public float Interval;
        public System.Action<Hazel.Udp.BroadcastPacket> OnPacketGet;
    }
}
