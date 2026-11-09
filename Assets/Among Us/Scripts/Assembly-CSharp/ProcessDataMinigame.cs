public class ProcessDataMinigame : Minigame
{
    public System.String[] DocTopics;
    public System.String[] DocTypes;
    public System.String[] DocExtensions;
    public float Duration;
    public ParallaxController scenery;
    public PassiveButton StartButton;
    public TMPro.TextMeshPro EstimatedText;
    public TMPro.TextMeshPro PercentText;
    public PowerTools.SpriteAnim LeftFolder;
    public PowerTools.SpriteAnim RightFolder;
    public UnityEngine.AnimationClip OpenFolderClip;
    public UnityEngine.AnimationClip CloseFolderClip;
    public UnityEngine.GameObject Status;
    public UnityEngine.SpriteRenderer Runner;
    public HorizontalGauge Gauge;
    public bool running;
    public FloatRange SceneRange;
    public UiElement BackButton;
    public UiElement DefaultButtonSelected;
}
