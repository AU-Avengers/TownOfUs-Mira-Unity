public class PassiveButtonManager : DestroyableSingleton
{
    public PassiveUiElement currentOver;
    public Controller controller;
    public PassiveButtonManager.ButtonStates currentState;
    public UnityEngine.Collider2D[] results;
    public enum ButtonStates : int
    {
        Up = 0,
        Down = 1,
        Drag = 2,
}
}
