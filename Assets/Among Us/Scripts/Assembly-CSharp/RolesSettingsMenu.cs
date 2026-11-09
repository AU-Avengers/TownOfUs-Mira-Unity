public class RolesSettingsMenu : UnityEngine.MonoBehaviour
{
    public UnityEngine.Transform ItemParent;
    public OptionBehaviour[] Children;
    public RoleOptionSetting SettingPrefab;
    public UnityEngine.GameObject AdvancedRolesSettings;
    public UnityEngine.GameObject RoleChancesSettings;
    public float YStart;
    public float YOffset;
    public AmongUs.GameOptions.IRoleOptionsCollection cachedData;
}
