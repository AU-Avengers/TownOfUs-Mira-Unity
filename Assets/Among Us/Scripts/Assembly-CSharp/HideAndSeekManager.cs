public class HideAndSeekManager : GameManager
{
    public LogicHnSMusic LogicMusic;
    public LogicGameFlowHnS LogicFlowHnS;
    public LogicOptionsHnS LogicOptionsHnS;
    public LogicHnSDangerLevel LogicDangerLevel;
    public LogicPingsHnS LogicPing;
    public LogicHnSDeathPopup LogicDeathPopup;
    public UnityEngine.AudioClip FinalHideAlertSFX;
    public UnityEngine.AudioClip FinalHideCountdownSFX;
    public HideAndSeekTimerBar TimerBarPrefab;
    public HideAndSeekDeathPopup DeathPopupPrefab;
    public Amongus.GameModes.HideAndSeek.HideAndSeekMusicCollection MusicCollection;
    public UnityEngine.AudioClip TaskFinishedSound;
    public ObjectPoolBehavior PingPool;
    public UnityEngine.Sprite BrokenEmergencyButton;
    public DeadBody horseBody;
    public TMPro.TextMeshPro someoneJustDiedText;
    public GameData.PlayerOutfit horseWranglerOutfit;
}
