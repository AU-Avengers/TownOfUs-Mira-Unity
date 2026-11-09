namespace AmongUs.QuickChat
{
    public class QuickChatMenuLandingPageButton : UnityEngine.MonoBehaviour
    {
        public PassiveButton button;
        public UnityEngine.BoxCollider2D collider;
        public UIScrollbarHelper scrollHelper;
        public TMPro.TMP_Text text;
        public UnityEngine.RectTransform textRect;
        public TextTranslatorTMP translator;
        public UnityEngine.SpriteRenderer[] backgroundSprites;
        public UnityEngine.SpriteRenderer[] shineSprites;
        public AmongUs.QuickChat.QuickChatTag tag;
    }
}
