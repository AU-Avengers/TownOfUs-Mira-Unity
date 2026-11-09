public class AbstractChatInputField : UnityEngine.MonoBehaviour
{
    public UnityEngine.SpriteRenderer background;
    public ChatInputFieldButton submitButton;
    public bool visible;
    public bool canSubmit;
    public System.Action OnSubmitEvent;
}
