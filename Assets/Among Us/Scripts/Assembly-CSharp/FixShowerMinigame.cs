public class FixShowerMinigame : Minigame
{
    public FloatRange hammerAngles;
    public FloatRange showerAngles;
    public float showerPos;
    public UnityEngine.SpriteRenderer mallet;
    public UnityEngine.Collider2D showerHead;
    public UnityEngine.AnimationCurve hammerAnim;
    public Controller controller;
    public float powerTime;
    public PowerBar powerBar;
    public UnityEngine.AudioClip[] bashSounds;
    public UnityEngine.AudioClip swingSound;
    public UnityEngine.GameObject leftGlyph;
    public UnityEngine.GameObject rightGlyph;
    public bool prevButtonHeld;
    public bool animating;
}
