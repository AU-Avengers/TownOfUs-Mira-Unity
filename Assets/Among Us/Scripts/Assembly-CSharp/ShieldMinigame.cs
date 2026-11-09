public class ShieldMinigame : Minigame
{
    public UnityEngine.Color OnColor;
    public UnityEngine.Color OffColor;
    public UnityEngine.SpriteRenderer[] Shields;
    public UnityEngine.SpriteRenderer Gauge;
    public System.Byte shields;
    public UnityEngine.AudioClip ShieldOnSound;
    public UnityEngine.AudioClip ShieldOffSound;
    public UnityEngine.Transform selectedButtonHighlight;
    public Controller controller;
    public int oldSelectedIndex;
}
