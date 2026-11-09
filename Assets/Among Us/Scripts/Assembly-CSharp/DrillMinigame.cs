public class DrillMinigame : Minigame
{
    public UnityEngine.SpriteRenderer CaseImage;
    public TMPro.TextMeshPro statusText;
    public PowerTools.SpriteAnim[] Buttons;
    public UnityEngine.AnimationClip BadAnim;
    public UnityEngine.AudioClip ButtonSound;
    public int MaxState;
    public System.Int32[] states;
    public PowerTools.SpriteAnim prevFixedButton;
    public float changeButtonDelay;
    public System.Int32[] drillButtonMaps;
}
