public class LiftWeightsMinigame : Minigame
{
    public UnityEngine.Transform barbell;
    public UnityEngine.Collider2D actionButton;
    public UnityEngine.Transform top;
    public UnityEngine.Transform bottom;
    public UnityEngine.AnimationCurve liftSpeedCurve;
    public UnityEngine.AnimationCurve dropSpeedCurve;
    public float secondsToLift;
    public UnityEngine.SpriteRenderer[] counters;
    public UnityEngine.Transform fillBarParent;
    public UnityEngine.SpriteRenderer fillBar;
    public UnityEngine.Transform validIndicator;
    public FloatRange fillBarScaleRange;
    public FloatRange validFillPercentRange;
    public UnityEngine.Sprite buffSprite;
    public UnityEngine.Sprite weakSprite;
    public UnityEngine.SpriteRenderer buffButton;
    public UnityEngine.SpriteRenderer hands;
    public UnityEngine.AudioClip startLiftingSound;
    public UnityEngine.AudioClip barfillSound;
    public UnityEngine.AudioClip completeRepSound;
    public UnityEngine.AudioClip completeAllRepsSound;
    public UnityEngine.AudioClip failRepSound;
    public Controller controller;
    public bool hasInput;
    public LiftWeightsMinigame.State state;
    public float currentBarFillPercent;
    public float liftStartTime;
    public float dropStartTime;
    public float secondsToDrop;
    public UnityEngine.AudioSource barfillAudioSource;
    public enum State : int
    {
        Idle = 0,
        Lifting = 1,
        Dropping = 2,
}
}
