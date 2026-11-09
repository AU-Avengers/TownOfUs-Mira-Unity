public class RoleBehaviour : UnityEngine.MonoBehaviour
{
    public AmongUs.GameOptions.RoleTypes Role;
    public StringNames StringName;
    public StringNames BlurbName;
    public StringNames BlurbNameMed;
    public StringNames BlurbNameLong;
    public UnityEngine.Color NameColor;
    public bool TasksCountTowardProgress;
    public bool CanUseKillButton;
    public bool CanBeKilled;
    public bool CanVent;
    public bool AffectedByLightAffectors;
    public int MaxCount;
    public RoleTeamTypes TeamType;
    public AbilityButtonSettings Ability;
    public AmongUs.GameOptions.RoleTypes DefaultGhostRole;
    public UnityEngine.AudioClip UseSound;
    public UnityEngine.AudioClip IntroSound;
    public PlayerControl Player;
    public AbilityButton buttonManager;
}
