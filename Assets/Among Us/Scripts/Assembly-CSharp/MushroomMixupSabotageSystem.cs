public class MushroomMixupSabotageSystem : UnityEngine.MonoBehaviour, ISystemType, IActivatable
{
    public float skinEmptyChance;
    public float hatEmptyChance;
    public System.String[] hatIds;
    public float visorEmptyChance;
    public System.String[] visorIds;
    public float petEmptyChance;
    public System.String[] petIds;
    public float secondsForAutoHeal;
    public MushroomMixupScreenTint screenTint;
    public MushroomMixupPlayerAnimation playerAnimationPrefab;
    public UnityEngine.AudioClip activateSfx;
    public UnityEngine.AudioClip deactivateSfx;
    public MushroomMixupSabotageSystem.State currentState;
    public float currentSecondsUntilHeal;
    public float syncTimer;
    public enum State : int
    {
        Inactive = 0,
        JustTriggered = 1,
        IdleButMixedUp = 2,
}
    public enum Operation : int
    {
        None = 0,
        TriggerSabotage = 1,
}
}
