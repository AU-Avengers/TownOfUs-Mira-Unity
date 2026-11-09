public class SweepMinigame : Minigame
{
    public UnityEngine.SpriteRenderer[] Spinners;
    public UnityEngine.SpriteRenderer[] Shadows;
    public UnityEngine.SpriteRenderer[] Lights;
    public HorizontalGauge[] Gauges;
    public int spinnerIdx;
    public float timer;
    public float SpinRate;
    public float initialTimer;
    public UnityEngine.AudioClip SpinningSound;
    public UnityEngine.AudioClip AcceptSound;
    public UnityEngine.AudioClip RejectSound;
    public UiElement BackButton;
    public UiElement DefaultButtonSelected;
}
