public class SampleMinigame : Minigame
{
    public TMPro.TextMeshPro UpperText;
    public TMPro.TextMeshPro LowerText;
    public float TimePerStep;
    public FloatRange platformY;
    public FloatRange dropperX;
    public UnityEngine.SpriteRenderer CenterPanel;
    public UnityEngine.SpriteRenderer Dropper;
    public UnityEngine.SpriteRenderer[] Tubes;
    public UnityEngine.SpriteRenderer[] Buttons;
    public UnityEngine.SpriteRenderer[] LowerButtons;
    public UnityEngine.AudioClip ButtonSound;
    public UnityEngine.AudioClip PanelMoveSound;
    public UnityEngine.AudioClip FailSound;
    public UnityEngine.AudioClip[] DropSounds;
    public UnityEngine.Transform whichButtonSelector;
    public int whichButtonSelected;
    public float selectMoveCooldown;
    public enum States : System.Byte
    {
        PrepareSample = 0,
        Complete = 16,
        AwaitingStart = 32,
        Selection = 64,
        Processing = 128,
}
}
