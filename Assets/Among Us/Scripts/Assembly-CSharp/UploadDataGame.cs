public class UploadDataGame : Minigame
{
    public PowerTools.SpriteAnim LeftFolder;
    public PowerTools.SpriteAnim RightFolder;
    public UnityEngine.AnimationClip FolderOpen;
    public UnityEngine.AnimationClip FolderClose;
    public UnityEngine.SpriteRenderer Runner;
    public HorizontalGauge Gauge;
    public TMPro.TextMeshPro PercentText;
    public TMPro.TextMeshPro EstimatedText;
    public TMPro.TextMeshPro SourceText;
    public TMPro.TextMeshPro TargetText;
    public UnityEngine.SpriteRenderer Button;
    public TextTranslatorTMP translator;
    public UnityEngine.GameObject Status;
    public UnityEngine.GameObject Tower;
    public int count;
    public float timer;
    public bool running;
    public UiElement BackButton;
    public UiElement DefaultButtonSelected;
}
