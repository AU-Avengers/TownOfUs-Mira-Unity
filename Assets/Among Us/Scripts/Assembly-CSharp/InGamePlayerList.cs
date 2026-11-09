public class InGamePlayerList : UnityEngine.MonoBehaviour
{
    public UnityEngine.Vector3 offsetFromEdge;
    public float windowWidth;
    public UnityEngine.Vector3 openPosition;
    public UnityEngine.Vector3 closedPosition;
    public float openTime;
    public float buttonHeight;
    public ObjectPoolBehavior buttonPool;
    public ControllerNavMenu controllerNavMenu;
    public UnityEngine.SpriteRenderer backgroundSprite;
    public UnityEngine.SpriteRenderer backgroundSpriteMask;
    public UnityEngine.GameObject ChatScreen;
    public ControllerButtonBehavior OpenChatButton;
    public InGamePlayerList.ListState currentState;
    public float openLevel;
    public enum ListState : int
    {
        Closed = 0,
        Open = 1,
        Opening = 2,
        Closing = 3,
}
}
