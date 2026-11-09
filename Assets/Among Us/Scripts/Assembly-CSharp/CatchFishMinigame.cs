public class CatchFishMinigame : Minigame
{
    public UnityEngine.Transform fishingRod;
    public UnityEngine.SpriteRenderer fishingLine;
    public UnityEngine.Vector3 rodPutAwayPosition;
    public FloatRange fishingRodXPositionRange;
    public UnityEngine.SpriteRenderer bauble;
    public UnityEngine.SpriteRenderer currentFish;
    public System.Single[] startXPositions;
    public FloatRange startYPositionRange;
    public UnityEngine.AnimationCurve[] fishMovementCurves;
    public float totalSwimTime;
    public UnityEngine.SpriteRenderer[] fishCounters;
    public UnityEngine.Sprite[] fishCounterSprites;
    public UnityEngine.SpriteRenderer caughtFish;
    public UnityEngine.Transform alert;
    public float caughtFishScale;
    public UnityEngine.AudioClip onHookSfx;
    public UnityEngine.AudioClip onMissSfx;
    public UnityEngine.AudioClip onCatchSfx;
    public Controller controller;
    public CatchFishMinigame.State currentState;
    public int numCaughtFish;
    public UnityEngine.Coroutine bounceCoroutine;
    public enum State : int
    {
        WaitingForFish = 0,
        FishOnHook = 1,
        FishEscaped = 2,
}
}
