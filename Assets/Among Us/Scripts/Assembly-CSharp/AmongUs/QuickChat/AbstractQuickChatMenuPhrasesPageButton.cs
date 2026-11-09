namespace AmongUs.QuickChat
{
    public class AbstractQuickChatMenuPhrasesPageButton : UnityEngine.MonoBehaviour
    {
        public PassiveButton button;
        public UnityEngine.BoxCollider2D collider;
        public UIScrollbarHelper scrollHelper;
        public TMPro.TextMeshPro text;
        public UnityEngine.RectTransform textRect;
        public UnityEngine.SpriteRenderer arrow;
        public UnityEngine.SpriteRenderer[] backgroundSprites;
        public AmongUs.QuickChat.QuickChatPhrase phrase;
        public int index;
        public int buttonCount;
        public float width;
        public UnityEngine.Material textMaterial;
    }
}
