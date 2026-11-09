public class EnterCodeMinigame : Minigame
{
    public TMPro.TextMeshPro NumberText;
    public TMPro.TextMeshPro TargetText;
    public UnityEngine.SpriteRenderer Card;
    public int number;
    public string numString;
    public bool animating;
    public bool cardOut;
    public bool done;
    public int targetNumber;
    public UnityEngine.AudioClip WalletOut;
    public UnityEngine.AudioClip NumberSound;
    public UnityEngine.AudioClip AcceptSound;
    public UnityEngine.AudioClip RejectSound;
    public UiElement BackButton;
    public UiElement DefaultButtonSelected;
}
