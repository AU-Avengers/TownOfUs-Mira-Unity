public class AcceptDivertPowerGame : Minigame
{
    public UnityEngine.LineRenderer[] LeftWires;
    public UnityEngine.LineRenderer[] RightWires;
    public UnityEngine.GameObject RightWireParent;
    public UnityEngine.GameObject LeftWireParent;
    public UnityEngine.SpriteRenderer Switch;
    public UnityEngine.AudioClip SwitchSound;
    public bool done;
    public bool prevHadInput;
    public float rotateAngle;
    public UnityEngine.Vector2 prevStickDir;
}
