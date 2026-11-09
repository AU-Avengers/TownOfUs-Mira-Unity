namespace AmongUs.QuickChat
{
    public class QuickChatMenuScroller : UnityEngine.MonoBehaviour
    {
        public Scroller scroller;
        public Scrollbar scrollBar;
        public UnityEngine.SpriteRenderer track;
        public UnityEngine.BoxCollider2D collider;
        public ScrollToSelection scrollToSelection;
        public UnityEngine.SpriteRenderer topGradient;
        public UnityEngine.Transform topGradientContainer;
        public UnityEngine.SpriteRenderer bottomGradient;
        public UnityEngine.Transform bottomGradientContainer;
        public float width;
        public float height;
        public UnityEngine.Color topGradientColor;
        public UnityEngine.Color bottomGradientColor;
    }
}
