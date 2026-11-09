public class TouchpadBehavior : UnityEngine.MonoBehaviour
{
    public float aspect;
    public bool touching;
    public bool firstTouch;
    public UnityEngine.Vector2 toCenter;
    public UnityEngine.Vector2 firstTouchPos;
    public UnityEngine.Vector2 delta;
    public UnityEngine.Vector2 fromCenter;
    public float touchpadSensitivity;
}
