public class EmergencyMinigame : Minigame
{
    public UnityEngine.SpriteRenderer ClosedLid;
    public UnityEngine.SpriteRenderer OpenLid;
    public UnityEngine.Transform meetingButton;
    public TMPro.TextMeshPro StatusText;
    public TMPro.TextMeshPro NumberText;
    public bool ButtonActive;
    public UnityEngine.AudioClip ButtonSound;
    public int state;
    public UiElement BackButton;
    public UiElement DefaultButtonSelected;
}
