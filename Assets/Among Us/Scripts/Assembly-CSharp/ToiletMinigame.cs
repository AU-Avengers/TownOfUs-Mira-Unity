public class ToiletMinigame : Minigame
{
    public UnityEngine.SpriteRenderer Needle;
    public UnityEngine.SpriteRenderer Pipes;
    public FloatRange StickRange;
    public UnityEngine.Collider2D Stick;
    public UnityEngine.SpriteRenderer Plunger;
    public UnityEngine.Sprite PlungerUp;
    public UnityEngine.Sprite PlungerDown;
    public float pressure;
    public Controller controller;
    public float lastY;
    public float plungeScale;
    public UnityEngine.AudioClip flushSound;
    public UnityEngine.AudioClip[] plungeSounds;
    public UnityEngine.AudioSource plungerSource;
    public float controllerStickPos;
}
