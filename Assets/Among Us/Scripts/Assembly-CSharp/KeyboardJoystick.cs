public class KeyboardJoystick : UnityEngine.MonoBehaviour, IVirtualJoystick
{
    public UnityEngine.Vector2 del;
    public Controller myController;
    public UnityEngine.Collider2D[] hitBuffer;
    public int touchId;
}
