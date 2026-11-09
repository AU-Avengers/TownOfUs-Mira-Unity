public class CycleButtonBehaviour : UnityEngine.MonoBehaviour, ITranslatedText
{
    public StringNames[] options;
    public StringNames BaseText;
    public TMPro.TextMeshPro Text;
    public UnityEngine.SpriteRenderer Background;
    public ButtonRolloverHandler Rollover;
    public UnityEngine.GameObject helpButton;
    public int curSelection;
    public TMPro.TextMeshPro quickChatInstructions;
}
