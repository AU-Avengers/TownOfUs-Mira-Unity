public class MineOreMinigame : Minigame
{
    public float powerBarSpeed;
    public float pikeaxeFirstAngle;
    public float pikeaxeSecondAngle;
    public float pikeaxeAnimTime;
    public float goodPercentage;
    public float greatPercentage;
    public UnityEngine.Collider2D pickaxe;
    public UnityEngine.GameObject pickaxeSprite;
    public UnityEngine.GameObject pickControllerHelper;
    public PowerBarMining powerBarMining;
    public UnityEngine.AudioClip[] rockHitWeak;
    public UnityEngine.AudioClip[] rockHitStrong;
    public UnityEngine.AudioClip[] rockRelease;
    public UnityEngine.AudioClip pickaxeSwing;
    public UnityEngine.AudioClip powerBarLoop;
    public UnityEngine.AudioSource powerBarAudioSource;
    public int currentOreCount;
    public CollectableOre currentOre;
    public Controller controller;
    public bool isMining;
}
