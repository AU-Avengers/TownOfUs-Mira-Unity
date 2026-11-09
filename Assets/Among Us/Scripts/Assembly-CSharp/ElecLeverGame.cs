public class ElecLeverGame : Minigame
{
    public UnityEngine.Sprite[] NumberIcons;
    public UnityEngine.SpriteRenderer NumberImage;
    public UnityEngine.SpriteRenderer[] Lights;
    public UnityEngine.Sprite LightOn;
    public UnityEngine.Sprite LightOff;
    public UnityEngine.Collider2D Handle;
    public UnityEngine.SpriteRenderer Bars;
    public FloatRange HandleRange;
    public bool finished;
    public Controller controller;
    public UnityEngine.AudioClip correctSound;
    public UnityEngine.AudioClip incorrectSound;
}
