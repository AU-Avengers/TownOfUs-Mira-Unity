public class ActiveInputManager : DestroyableSingleton
{
    public ActiveInputManager.InputType testCurrentControlType;
    public System.Double kChangeTime;
    public System.Double mChangeTime;
    public System.Double jChangeTime;
    public System.Double tChangeTime;
    public UnityEngine.Vector2 lastMousePosition;
    public enum InputType : int
    {
        Joystick = 0,
        Keyboard = 1,
        Touch = 2,
}
}
