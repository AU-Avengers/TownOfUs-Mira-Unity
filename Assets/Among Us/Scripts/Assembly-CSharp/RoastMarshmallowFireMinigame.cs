public class RoastMarshmallowFireMinigame : Minigame
{
    public float timeToToasted;
    public float timeToBurnt;
    public UnityEngine.Animator fireAnimator;
    public UnityEngine.Animator bagAnimator;
    public UnityEngine.Animator stickAnimator;
    public UnityEngine.Animator marshmallowAnimator;
    public UnityEngine.SpriteRenderer toastedMarshmallow;
    public PassiveButton bagMarshmallowButton;
    public PassiveButton stickMarshmallowButton;
    public UnityEngine.AudioClip sfxMarshmallowOnStick;
    public UnityEngine.AudioClip sfxMarshmallowDone;
    public UnityEngine.AudioClip sfxTooSoon;
    public UnityEngine.AudioClip sfxBurnt;
    public UnityEngine.AudioClip sfxFireAmbience;
    public RoastMarshmallowFireMinigame.State state;
    public RoastMarshmallowFireMinigame.MarshmallowState marshmallowState;
    public float roastingStartTime;
    public float timeOfLastStateTransition;
    public enum State : int
    {
        Waiting = 0,
        Placing = 1,
        Toasting = 2,
        Taking = 3,
        Removing_Fail = 4,
        Removing_Success = 5,
}
    public enum MarshmallowState : int
    {
        New = 0,
        Toasted = 1,
        Burnt = 2,
}
}
