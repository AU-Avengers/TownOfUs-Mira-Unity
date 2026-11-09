public class CreateGameOptions : UnityEngine.MonoBehaviour, IConnectButton
{
    public UnityEngine.AudioClip IntroMusic;
    public UnityEngine.GameObject Content;
    public UnityEngine.SpriteRenderer Foreground;
    public PowerTools.SpriteAnim connectIcon;
    public UnityEngine.AnimationClip connectClip;
    public UnityEngine.GameObject ImpostorGraphic;
    public AprilFoolsModeToggleButton AprilFoolsToggle;
    public UiElement BackButton;
    public UiElement DefaultButtonSelected;
    public PassiveButton RegionButton;
    public Logger logger;
}
