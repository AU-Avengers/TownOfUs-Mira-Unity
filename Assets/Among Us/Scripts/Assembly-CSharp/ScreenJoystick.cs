public class ScreenJoystick : UnityEngine.MonoBehaviour, IVirtualJoystick
{
    public UnityEngine.Collider2D[] hitBuffer;
    public Controller myController;
    public int touchId;
}
