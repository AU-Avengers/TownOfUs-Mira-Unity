namespace AmongUs.QuickChat
{
    public class QuickChatMenu : UnityEngine.MonoBehaviour
    {
        public AmongUs.QuickChat.QuickChatData data;
        public UnityEngine.Transform container;
        public UnityEngine.SpriteRenderer frame;
        public UnityEngine.Transform topContentBlocker;
        public UnityEngine.Transform bottomContentBlocker;
        public PassiveButton closeButton;
        public UnityEngine.GameObject closeButtonGlyph;
        public UnityEngine.AnimationCurve animationIn;
        public UnityEngine.AnimationCurve animationOut;
        public UnityEngine.Transform pagesContainer;
        public AmongUs.QuickChat.QuickChatMenuLandingPage landingPage;
        public AmongUs.QuickChat.QuickChatMenuPhrasesPage phrasesPage;
        public AmongUs.QuickChat.QuickChatMenuHeader header;
        public AmongUs.QuickChat.QuickChatMenuVoteTimer timer;
        public AmongUs.QuickChat.QuickChatPhraseBuilder builder;
        public bool isOpen;
        public float height;
        public float width;
        public float targetXPos;
        public System.Action OnOpenEvent;
        public System.Action OnCloseEvent;
    }
}
