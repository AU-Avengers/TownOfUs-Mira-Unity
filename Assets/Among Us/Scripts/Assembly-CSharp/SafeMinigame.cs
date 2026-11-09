public class SafeMinigame : Minigame
{
    public TMPro.TextMeshPro ComboText;
    public UnityEngine.Collider2D Tumbler;
    public UnityEngine.SpriteRenderer TumblerBehind;
    public UnityEngine.Collider2D Spinner;
    public UnityEngine.SpriteRenderer[] Arrows;
    public System.Int32[] combo;
    public System.Boolean[] latched;
    public System.Boolean[] vibration;
    public Controller controller;
    public float lastTumDir;
    public UnityEngine.Vector2 lastMouseVec;
    public float spinTime;
    public float spinDel;
    public float spinVel;
    public float reversalBuffer;
    public UnityEngine.AudioClip DialTurnSound;
    public UnityEngine.AudioClip DialGoodSound;
    public UnityEngine.AudioClip SpinnerStartSound;
    public UnityEngine.AudioClip SpinnerFreeSound;
    public UnityEngine.AudioClip SpinnerStopSound;
    public UnityEngine.AudioSource loopSound;
    public bool prevHadLeftInput;
    public bool prevHadRightInput;
    public UnityEngine.Vector2 prevLeftInput;
    public UnityEngine.Vector2 prevRightInput;
    public float leftStickStartAngle;
    public float TopSpinRate;
}
