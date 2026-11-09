public class OptionsMenuBehaviour : UnityEngine.MonoBehaviour, ITranslatedText
{
    public UnityEngine.SpriteRenderer Background;
    public UnityEngine.SpriteRenderer JoystickButton;
    public UnityEngine.SpriteRenderer TouchButton;
    public SlideBar JoystickSizeSlider;
    public FloatRange JoystickSizes;
    public SlideBar SoundSlider;
    public SlideBar MusicSlider;
    public ToggleButtonBehaviour CensorChatButton;
    public ToggleButtonBehaviour DisableMouseMovement;
    public ToggleButtonBehaviour EnableFriendInvitesButton;
    public ToggleButtonBehaviour ColorBlindButton;
    public UnityEngine.GameObject KeyboardOptions;
    public UnityEngine.GameObject MouseAndKeyboardOptions;
    public ToggleButtonBehaviour StreamerModeButton;
    public UnityEngine.GameObject TermsOfUsePlayStationPopup;
    public TMPro.TextMeshPro TermsOfUsePlayStationEULAText;
    public BugReportPopup bugReportPopup;
    public bool Toggle;
    public TabGroup[] Tabs;
    public bool grabbedControllerButtons;
    public UiElement BackButton;
    public UiElement DefaultButtonSelected;
}
