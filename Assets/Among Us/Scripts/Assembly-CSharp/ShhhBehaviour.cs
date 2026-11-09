public class ShhhBehaviour : UnityEngine.MonoBehaviour
{
    public UnityEngine.SpriteRenderer Background;
    public UnityEngine.SpriteRenderer Body;
    public UnityEngine.SpriteRenderer Hand;
    public TMPro.TextMeshPro TextImage;
    public float RotateSpeed;
    public Vector2Range HandTarget;
    public UnityEngine.AnimationCurve PositionEasing;
    public FloatRange HandRotate;
    public UnityEngine.AnimationCurve RotationEasing;
    public Vector2Range TextTarget;
    public UnityEngine.AnimationCurve TextEasing;
    public float Duration;
    public float Delay;
    public float TextDuration;
    public float PulseDuration;
    public float PulseSize;
    public float HoldDuration;
    public bool Autoplay;
}
