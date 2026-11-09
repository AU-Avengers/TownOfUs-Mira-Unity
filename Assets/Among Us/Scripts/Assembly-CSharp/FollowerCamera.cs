public class FollowerCamera : UnityEngine.MonoBehaviour
{
    public UnityEngine.MonoBehaviour Target;
    public UnityEngine.Vector2 Offset;
    public bool Locked;
    public float shakeAmount;
    public float shakePeriod;
    public bool OverrideScreenShakeEnabled;
    public UnityEngine.Vector2 centerPosition;
}
