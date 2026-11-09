public class ProgressBar : UnityEngine.MonoBehaviour
{
    public float Value;
    public float CapValue;
    public float MaxValue;
    public float maskScale;
    public UnityEngine.SpriteRenderer Mask;
    public UnityEngine.SpriteRenderer cap;
    public UnityEngine.SpriteRenderer capGlow;
    public float capScale;
    public float capGlowSizePadding;
    public float lastValue;
    public float lastCapDiff;
}
