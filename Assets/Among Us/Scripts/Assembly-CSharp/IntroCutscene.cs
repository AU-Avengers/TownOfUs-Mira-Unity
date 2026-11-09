public class IntroCutscene : UnityEngine.MonoBehaviour
{
    public TMPro.TextMeshPro TeamTitle;
    public TMPro.TextMeshPro ImpostorText;
    public TMPro.TextMeshPro YouAreText;
    public TMPro.TextMeshPro RoleText;
    public TMPro.TextMeshPro RoleBlurbText;
    public TMPro.TextMeshPro HideAndSeekTimerText;
    public PoolablePlayer PlayerPrefab;
    public PoolablePlayer OurCrewmate;
    public UnityEngine.GameObject HideAndSeekPanels;
    public UnityEngine.GameObject CrewmateRules;
    public UnityEngine.GameObject ImpostorRules;
    public UnityEngine.MeshRenderer BackgroundBar;
    public UnityEngine.MeshRenderer Foreground;
    public FloatRange ForegroundRadius;
    public UnityEngine.SpriteRenderer FrontMost;
    public UnityEngine.AudioClip IntroStinger;
    public TMPro.TextMeshPro ImpostorName;
    public TMPro.TextMeshPro ImpostorTitle;
    public UnityEngine.Vector3 impostorPos;
    public float impostorScale;
    public UnityEngine.AnimationClip HnSSeekerSpawnAnim;
    public UnityEngine.AnimationClip HnSSeekerSpawnHorseAnim;
    public UnityEngine.AnimationClip HnSSeekerSpawnHorseInGameAnim;
    public UnityEngine.AnimationClip HnSSeekerSpawnLongAnim;
    public UnityEngine.AnimationClip HnSSeekerSpawnLongInGameAnim;
    public PoolablePlayer HideAndSeekPlayerVisual;
    public PoolablePlayer HorseWrangleVisualSuit;
    public PoolablePlayer HorseWrangleVisualPlayer;
    public PoolablePlayer ourCrewmate;
    public DualshockLightManager.LightOverlayHandle overlayHandle;
}
