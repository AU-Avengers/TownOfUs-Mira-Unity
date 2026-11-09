public class GameSettingMenu : UnityEngine.MonoBehaviour
{
    public RolesSettingsMenu RolesSettings;
    public UnityEngine.GameObject RegularGameSettings;
    public UnityEngine.GameObject HideNSeekSettings;
    public UnityEngine.GameObject Tabs;
    public TMPro.TextMeshPro RoleName;
    public TMPro.TextMeshPro RoleBlurb;
    public UnityEngine.SpriteRenderer RoleIcon;
    public UnityEngine.SpriteRenderer GameSettingsHightlight;
    public UnityEngine.SpriteRenderer RolesSettingsHightlight;
    public UnityEngine.Transform[] AllItems;
    public UnityEngine.Transform[] AllHideAndSeekItems;
    public Scroller HideAndSeekScroller;
    public Scroller Scroller;
    public float YStart;
    public float YOffset;
    public UnityEngine.Transform[] HideForOnline;
    public UiElement BackButton;
    public UiElement AdvancedSettingsBackButton;
}
