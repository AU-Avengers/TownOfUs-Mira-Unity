public class AirshipUploadGame : Minigame
{
    public UnityEngine.SpriteRenderer Phone;
    public UnityEngine.Collider2D Hotspot;
    public UnityEngine.Collider2D Perfect;
    public UnityEngine.Collider2D Good;
    public UnityEngine.Collider2D Poor;
    public UnityEngine.GameObject PerfectIcon;
    public UnityEngine.GameObject GoodIcon;
    public UnityEngine.GameObject PoorIcon;
    public UnityEngine.GameObject NoneIcon;
    public HorizontalGauge gauge;
    public float moveSpeed;
    public float timer;
    public UnityEngine.AudioClip nearSound;
    public float BeepPeriod;
    public float beepTimer;
    public Controller cont;
    public UnityEngine.SpriteRenderer promptGlyph;
    public UnityEngine.Color glyphColor;
    public float glyphDisappearDelay;
    public bool phoneGrabbed;
}
