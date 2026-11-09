public class AlignGame : Minigame
{
    public Controller myController;
    public FloatRange YRange;
    public UnityEngine.AnimationCurve curve;
    public UnityEngine.LineRenderer centerline;
    public UnityEngine.LineRenderer[] guidelines;
    public UnityEngine.SpriteRenderer engine;
    public UnityEngine.Collider2D col;
    public float pulseTimer;
    public bool wasPushingJoystick;
    public float initialY;
    public TouchpadBehavior touchpad;
}
