public class DoorCardSwipeGame : Minigame, IDoorMinigame
{
    public UnityEngine.Color gray;
    public UnityEngine.Color green;
    public DoorCardSwipeGame.TaskStages State;
    public Controller myController;
    public FloatRange YRange;
    public float minAcceptedTime;
    public UnityEngine.Collider2D col;
    public UnityEngine.SpriteRenderer confirmSymbol;
    public UnityEngine.Sprite AcceptSymbol;
    public UnityEngine.Sprite RejectSymbol;
    public TMPro.TextMeshPro StatusText;
    public UnityEngine.AudioClip AcceptSound;
    public UnityEngine.AudioClip DenySound;
    public UnityEngine.AudioClip[] CardMove;
    public UnityEngine.AudioClip WalletOut;
    public float dragTime;
    public bool moving;
    public UnityEngine.Vector2 prevStickInput;
    public bool hadPrev;
    public OpenableDoor MyDoor;
    public enum TaskStages : int
    {
        Before = 0,
        Animating = 1,
        Inserted = 2,
        After = 3,
}
}
