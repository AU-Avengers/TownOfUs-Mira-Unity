public class ConsoleJoystick : UnityEngine.MonoBehaviour, IVirtualJoystick
{
    public UnityEngine.Vector2 delta;
    public UnityEngine.Vector2 deltaR;
    public enum ConsoleInputState : int
    {
        Gameplay = 0,
        Menu = 1,
        Task = 2,
        Sabotage = 3,
        Vent = 4,
        QuickChat = 5,
        None = 6,
}
}
