public class AirshipAuthGame : Minigame
{
    public TMPro.TextMeshPro TargetText;
    public TMPro.TextMeshPro NumberText;
    public TMPro.TextMeshPro OtherStatusText;
    public int number;
    public string numString;
    public bool animating;
    public HeliSabotageSystem system;
    public UnityEngine.SpriteRenderer OurLight;
    public UnityEngine.SpriteRenderer TheirLight;
    public UnityEngine.SpriteRenderer TimeBar;
    public UnityEngine.AudioClip ButtonSound;
    public UnityEngine.AudioClip AcceptSound;
    public UnityEngine.AudioClip RejectSound;
    public int OtherConsoleId;
    public bool evenColor;
    public UiElement defaultSelection;
    public UiElement closeButton;
}
