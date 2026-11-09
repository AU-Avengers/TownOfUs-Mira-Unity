public class CardSlideGame : Minigame
{
    public UnityEngine.Color gray;
    public UnityEngine.Color green;
    public CardSlideGame.TaskStages State;
    public Controller myController;
    public FloatRange XRange;
    public FloatRange AcceptedTime;
    public UnityEngine.Collider2D col;
    public UnityEngine.SpriteRenderer redLight;
    public UnityEngine.SpriteRenderer greenLight;
    public TMPro.TextMeshPro StatusText;
    public UnityEngine.AudioClip AcceptSound;
    public UnityEngine.AudioClip DenySound;
    public UnityEngine.AudioClip[] CardMove;
    public UnityEngine.AudioClip WalletOut;
    public float dragTime;
    public bool moving;
    public TouchpadBehavior touchpad;
    public UnityEngine.Vector2 prevStickInput;
    public float xPos;
    public bool hadPrev;
    public enum TaskStages : int
    {
        Before = 0,
        Animating = 1,
        Inserted = 2,
        After = 3,
}
}
