public class ShipStatus : InnerNet.InnerNetObject
{
    public UnityEngine.Color CameraColor;
    public float MaxLightRadius;
    public float MinLightRadius;
    public float MapScale;
    public MapBehaviour MapPrefab;
    public ExileController ExileCutscenePrefab;
    public MeetingCalledAnimation EmergencyOverlay;
    public MeetingCalledAnimation ReportOverlay;
    public UnityEngine.Sprite MeetingBackground;
    public UnityEngine.Sprite BrokenEmergencyButton;
    public SystemConsole EmergencyButton;
    public UnityEngine.Vector2 InitialSpawnCenter;
    public UnityEngine.Vector2 MeetingSpawnCenter;
    public UnityEngine.Vector2 MeetingSpawnCenter2;
    public float SpawnRadius;
    public NormalPlayerTask[] CommonTasks;
    public NormalPlayerTask[] LongTasks;
    public NormalPlayerTask[] ShortTasks;
    public PlayerTask[] SpecialTasks;
    public UnityEngine.Transform[] DummyLocations;
    public SurvCamera[] AllCameras;
    public OpenableDoor[] AllDoors;
    public Console[] AllConsoles;
    public Ladder[] Ladders;
    public StringNames[] SystemNames;
    public StringNames[] ExtraTaskNames;
    public UnityEngine.AudioClip SabotageSound;
    public UnityEngine.AnimationClip[] WeaponFires;
    public PowerTools.SpriteAnim WeaponsImage;
    public UnityEngine.AudioClip[] VentMoveSounds;
    public UnityEngine.AudioClip VentEnterSound;
    public UnityEngine.AudioClip VentExitSound;
    public UnityEngine.AnimationClip HatchActive;
    public PowerTools.SpriteAnim Hatch;
    public UnityEngine.ParticleSystem HatchParticles;
    public UnityEngine.AnimationClip ShieldsActive;
    public PowerTools.SpriteAnim[] ShieldsImages;
    public UnityEngine.SpriteRenderer ShieldBorder;
    public UnityEngine.Sprite ShieldBorderOn;
    public MedScannerBehaviour MedScanner;
    public int WeaponFireIdx;
    public float Timer;
    public float EmergencyCooldown;
    public ShipStatus.MapType Type;
    public Logger logger;
    public int numScans;
    public enum MapType : int
    {
        Ship = 0,
        Hq = 1,
        Pb = 2,
        Fungle = 3,
        Bunker = 10,
}
}
