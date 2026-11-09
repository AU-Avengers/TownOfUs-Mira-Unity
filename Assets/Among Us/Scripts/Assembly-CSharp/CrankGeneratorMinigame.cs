public class CrankGeneratorMinigame : Minigame
{
    public float targetProgress;
    public float progressDecay;
    public int crankAudioRate;
    public UnityEngine.SpriteRenderer powerBarSpriteRenderer;
    public UnityEngine.Collider2D crank;
    public UnityEngine.Transform checkpoint;
    public UnityEngine.SpriteRenderer lightbulb;
    public UnityEngine.SpriteRenderer miniLights;
    public UnityEngine.AudioClip[] turnAudioClips;
    public UnityEngine.AudioClip motorAudioClip;
    public float gamepadAngleProgressMul;
    public Controller controller;
    public System.Nullable<UnityEngine.Vector2> prevGamepadAngle;
    public float progress;
    public float currentAngle;
    public bool lightbulbEffect;
    public int crankAudioDiv;
    public UnityEngine.AudioSource motorAudioSource;
    public bool finishCrank;
}
