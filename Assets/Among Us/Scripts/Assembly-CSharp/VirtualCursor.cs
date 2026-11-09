public class VirtualCursor : UnityEngine.MonoBehaviour
{
    public float speed;
    public float currentSpeed;
    public float acceleration;
    public UnityEngine.Vector2 screenBounds;
    public UnityEngine.Vector3 position;
    public UnityEngine.Camera cam;
    public int framesVisible;
    public UnityEngine.SpriteRenderer sr;
    public UnityEngine.Vector2 prevTouchPos;
    public bool setTouchPos;
}
