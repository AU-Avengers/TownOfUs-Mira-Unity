public class MonitorOxyMinigame : Minigame
{
    public UnityEngine.SpriteRenderer[] Targets;
    public UnityEngine.BoxCollider2D[] Sliders;
    public VerticalSpriteGauge[] Fills;
    public FloatRange YRange;
    public FloatRange[] RandomRanges;
    public Controller controller;
    public UnityEngine.AudioClip[] DragSounds;
    public UnityEngine.AudioSource ActiveSound;
    public UnityEngine.Transform selectorObject;
    public TouchpadBehavior touchpad;
    public float initialY;
    public int selectedIndex;
    public bool prevHadInput;
    public float selectCooldown;
    public bool isTouchInput;
}
