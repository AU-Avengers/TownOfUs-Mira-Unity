public class SwitchMinigame : Minigame
{
    public UnityEngine.Color OnColor;
    public UnityEngine.Color OffColor;
    public ShipStatus ship;
    public UnityEngine.SpriteRenderer[] switches;
    public UnityEngine.SpriteRenderer[] lights;
    public RadioWaveBehaviour top;
    public HorizontalGauge middle;
    public FlatWaveBehaviour bottom;
    public UnityEngine.AudioClip FlipSound;
    public UnityEngine.Transform selectorHighlight;
    public int selectedIndex;
    public float selectorCooldown;
    public bool prevHadVerticalInput;
}
