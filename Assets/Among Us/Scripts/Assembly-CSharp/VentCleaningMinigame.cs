public class VentCleaningMinigame : Minigame
{
    public FloatRange XSpan;
    public FloatRange YSpan;
    public ObjectPoolBehavior dirtPool;
    public UnityEngine.GameObject ventLidClosed;
    public UnityEngine.GameObject ventLidOpened;
    public UiElement backButton;
    public UnityEngine.AudioClip VentOpenSound;
    public UnityEngine.AudioClip ImpostorDiscoveredSound;
    public UnityEngine.AudioClip CleanedSound;
    public UnityEngine.SpriteRenderer[] SpiderWebs;
    public float cleaningDistanceThreshold;
    public UnityEngine.Transform selectorObject;
    public UnityEngine.SpriteRenderer selectorHand;
    public int numberOfDirts;
    public int numberOfDirtsCleanedUp;
    public bool ventOpen;
    public VentilationSystem ventSystem;
}
