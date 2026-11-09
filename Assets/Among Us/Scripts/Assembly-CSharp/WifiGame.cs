public class WifiGame : Minigame
{
    public SlideBar Slider;
    public TMPro.TextMeshPro StatusText;
    public UnityEngine.SpriteRenderer[] Lights;
    public UnityEngine.Sprite LightOn;
    public UnityEngine.Sprite LightOff;
    public UnityEngine.AudioClip SliderClick;
    public bool WifiOff;
    public TouchpadBehavior touchpad;
    public float initialSlider;
    public Controller controller;
}
