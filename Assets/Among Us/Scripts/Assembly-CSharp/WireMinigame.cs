public class WireMinigame : Minigame
{
    public UnityEngine.Sprite[] Symbols;
    public Wire[] LeftNodes;
    public WireNode[] RightNodes;
    public UnityEngine.SpriteRenderer[] LeftLights;
    public UnityEngine.SpriteRenderer[] RightLights;
    public Controller myController;
    public System.SByte[] ExpectedWires;
    public System.SByte[] ActualWires;
    public UnityEngine.AudioClip[] WireSounds;
    public int prevSelectedWireIndex;
    public int selectedWireIndex;
    public bool prevButtonDown;
    public float inputCooldown;
    public UnityEngine.Vector2 controllerWirePos;
    public UnityEngine.GameObject[] selectingWireGlyphs;
    public UnityEngine.GameObject[] movingWireGlyphs;
    public UnityEngine.Transform selectedWireUI;
}
