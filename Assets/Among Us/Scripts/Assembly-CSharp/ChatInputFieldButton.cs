public class ChatInputFieldButton : UnityEngine.MonoBehaviour
{
    public TMPro.TextMeshPro text;
    public TextTranslatorTMP translator;
    public PassiveButton button;
    public UnityEngine.BoxCollider2D collider;
    public UnityEngine.Transform inputGlyph;
    public UnityEngine.SpriteRenderer[] backgroundSprites;
    public UnityEngine.SpriteRenderer[] iconSprites;
    public System.Action OnPressed;
    public System.Action OnSizeChanged;
}
