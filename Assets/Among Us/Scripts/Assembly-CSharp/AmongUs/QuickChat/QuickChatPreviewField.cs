namespace AmongUs.QuickChat
{
    public class QuickChatPreviewField : AbstractChatInputField
    {
        public ChatInputFieldButton clearButton;
        public ChatInputFieldButton undoButton;
        public TMPro.TextMeshPro warningText;
        public TMPro.TextMeshPro text;
        public TMPro.TextMeshPro placeholderText;
        public System.Action OnClearPressedEvent;
        public System.Action OnUndoPressedEvent;
    }
}
