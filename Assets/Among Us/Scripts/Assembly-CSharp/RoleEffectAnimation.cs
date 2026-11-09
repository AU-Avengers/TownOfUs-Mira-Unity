public class RoleEffectAnimation : UnityEngine.MonoBehaviour
{
    public RoleEffectAnimation.EffectType effectType;
    public UnityEngine.AnimationClip Clip;
    public PowerTools.SpriteAnim Animator;
    public System.Action MidAnimCB;
    public UnityEngine.SpriteRenderer Renderer;
    public UnityEngine.AudioClip UseSound;
    public UnityEngine.AudioSource AudioSource;
    public PlayerControl parent;
    public enum EffectType : int
    {
        Default = 0,
        ProtectLoop = 1,
        Shapeshift = 2,
}
    public enum SoundType : int
    {
        None = 0,
        Local = 1,
        Global = 2,
}
}
