public class Minigame : UnityEngine.MonoBehaviour
{
    public TransitionType TransType;
    public UnityEngine.Vector2 TargetPosition;
    public PlayerTask MyTask;
    public NormalPlayerTask MyNormTask;
    public Minigame.CloseState amClosing;
    public bool amOpening;
    public UnityEngine.AudioClip OpenSound;
    public UnityEngine.AudioClip CloseSound;
    public SpecialInputHandler inputHandler;
    public bool multistageMinigameChecked;
    public MultistageMinigame multistageMinigameParent;
    public Logger logger;
    public float timeOpened;
    public enum CloseState : int
    {
        None = 0,
        Waiting = 1,
        Closing = 2,
}
}
