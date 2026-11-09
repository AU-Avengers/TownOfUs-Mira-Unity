public class MovingPlatformBehaviour : UnityEngine.MonoBehaviour, ISystemType
{
    public UnityEngine.Vector3 LeftPosition;
    public UnityEngine.Vector3 RightPosition;
    public UnityEngine.Vector3 DisabledPosition;
    public UnityEngine.Vector3 LeftUsePosition;
    public UnityEngine.Vector3 RightUsePosition;
    public UnityEngine.AudioClip MovingSound;
    public bool IsLeft;
    public PlayerControl Target;
    public System.Byte useId;
}
