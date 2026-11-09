public class DiagnosticGame : Minigame
{
    public VerticalGauge Gauge;
    public UnityEngine.SpriteRenderer StartButton;
    public float TimePerStep;
    public TMPro.TextMeshPro Text;
    public int TargetNum;
    public UnityEngine.SpriteRenderer[] Targets;
    public UnityEngine.Color goodBarColor;
    public UnityEngine.AudioClip StartSound;
    public UnityEngine.AudioClip CorrectSound;
    public UnityEngine.AudioClip TickSound;
    public UiElement BackButton;
    public UiElement DefaultButtonSelected;
    public int lastPercent;
}
