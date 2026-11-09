public class TelescopeGame : Minigame
{
    public bool grabbed;
    public UnityEngine.Transform Background;
    public UnityEngine.SpriteRenderer ItemDisplay;
    public UnityEngine.BoxCollider2D[] Items;
    public UnityEngine.BoxCollider2D TargetItem;
    public UnityEngine.BoxCollider2D Reticle;
    public UnityEngine.SpriteRenderer ReticleImage;
    public UnityEngine.Coroutine blinky;
    public UnityEngine.AudioClip BlipSound;
    public FloatRange BlipDelay;
    public TouchpadBehavior touchpad;
    public UnityEngine.Vector3 initialPos;
}
