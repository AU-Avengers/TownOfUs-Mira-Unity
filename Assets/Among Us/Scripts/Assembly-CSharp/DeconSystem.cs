public class DeconSystem : UnityEngine.MonoBehaviour, ISystemType
{
    public SomeKindaDoor UpperDoor;
    public SomeKindaDoor LowerDoor;
    public float DoorOpenTime;
    public float DeconTime;
    public UnityEngine.AudioClip SpraySound;
    public UnityEngine.ParticleSystem[] Particles;
    public SystemTypes TargetSystem;
    public float timer;
    public UnityEngine.Collider2D RoomArea;
    public DecontamNumController FloorText;
    public UnityEngine.Coroutine sprayers;
    public enum States : System.Byte
    {
        Idle = 0,
        Enter = 1,
        Closed = 2,
        Exit = 4,
        HeadingUp = 8,
}
}
