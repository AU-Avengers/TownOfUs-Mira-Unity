namespace InnerNet
{
    public class InnerNetObject : UnityEngine.MonoBehaviour
    {
        public System.UInt32 SpawnId;
        public System.UInt32 NetId;
        public System.UInt32 DirtyBits;
        public InnerNet.SpawnFlags SpawnFlags;
        public Hazel.SendOption sendMode;
        public int OwnerId;
        public bool DespawnOnDestroy;
    }
}
