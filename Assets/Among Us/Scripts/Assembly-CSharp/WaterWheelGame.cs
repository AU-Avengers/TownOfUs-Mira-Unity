public class WaterWheelGame : Minigame
{
    public UnityEngine.SpriteRenderer Wheel;
    public VerticalSpriteGauge WaterLevel;
    public UnityEngine.SpriteRenderer Watertop;
    public int WheelScale;
    public UnityEngine.AudioClip FillStart;
    public UnityEngine.AudioClip FillLoop;
    public UnityEngine.AudioClip WheelTurn;
    public TouchpadBehavior touchpad;
    public float Rate;
    public UnityEngine.AudioSource fillSound;
    public UnityEngine.Vector2 prevStickInput;
    public bool hadPrev;
    public bool grabbed;
}
