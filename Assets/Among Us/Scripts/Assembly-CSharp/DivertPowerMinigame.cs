public class DivertPowerMinigame : Minigame
{
    public SystemTypes[] SliderOrder;
    public UnityEngine.Collider2D[] Sliders;
    public UnityEngine.LineRenderer[] Wires;
    public VerticalGauge[] Gauges;
    public int sliderId;
    public FloatRange SliderY;
    public Controller myController;
    public ActionMapGlyphDisplay glyphDisplay;
    public int inputJoystick;
    public bool prevHadInput;
}
