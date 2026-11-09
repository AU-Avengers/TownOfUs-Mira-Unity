namespace AmongUs.QuickChat
{
    public class QuickChatMenuHeader : UnityEngine.MonoBehaviour
    {
        public UnityEngine.Transform content;
        public TMPro.TextMeshPro text;
        public UnityEngine.Transform textMask;
        public UnityEngine.Transform textGradient;
        public PassiveButton backButton;
        public UnityEngine.BoxCollider2D backButtonCollider;
        public UnityEngine.Transform divider;
        public UnityEngine.GameObject favoriteBox;
        public UnityEngine.GameObject favoriteBoxContainer;
        public UnityEngine.GameObject favoriteBoxGlyph;
        public UnityEngine.SpriteRenderer favoriteBoxBackground;
        public float width;
        public float height;
        public float defaultFontSize;
        public System.Action OnBackPressedEvent;
    }
}
