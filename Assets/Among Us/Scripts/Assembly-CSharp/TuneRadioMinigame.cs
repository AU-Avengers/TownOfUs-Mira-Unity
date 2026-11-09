public class TuneRadioMinigame : Minigame
{
    public RadioWaveBehaviour actualSignal;
    public DialBehaviour dial;
    public UnityEngine.SpriteRenderer redLight;
    public UnityEngine.SpriteRenderer greenLight;
    public float Tolerance;
    public float targetAngle;
    public bool finished;
    public float steadyTimer;
    public UnityEngine.AudioClip StaticSound;
    public UnityEngine.AudioClip RadioSound;
}
