public class MedScanMinigame : Minigame
{
    public TMPro.TextMeshPro text;
    public TMPro.TextMeshPro charStats;
    public HorizontalGauge gauge;
    public MedScanSystem medscan;
    public float ScanDuration;
    public float ScanTimer;
    public string completeString;
    public UnityEngine.AudioClip ScanSound;
    public UnityEngine.AudioClip TextSound;
    public UnityEngine.Coroutine walking;
    public MedScanMinigame.PositionState state;
    public enum PositionState : int
    {
        None = 0,
        WalkingToPad = 1,
        WalkingToOffset = 2,
}
}
