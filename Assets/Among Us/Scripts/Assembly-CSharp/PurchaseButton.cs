public class PurchaseButton : UnityEngine.MonoBehaviour
{
    public UnityEngine.SpriteRenderer PurchasedIcon;
    public UnityEngine.SpriteRenderer LimitedTimeIcon;
    public UpdateProductTimerDisplay LimitedTimeText;
    public UnityEngine.SpriteRenderer CrewHeadImage;
    public HatParent HatImage;
    public VisorLayer VisorLayer;
    public UnityEngine.Sprite MannequinFrame;
    public LoadingSpinner LoadingIndicator;
    public UnityEngine.SpriteRenderer Background;
    public UnityEngine.SpriteRenderer SelectionHighlight;
    public UnityEngine.SpriteRenderer GlassSprite;
    public UnityEngine.SpriteRenderer GlassMask;
    public UnityEngine.SpriteRenderer ImageMask;
    public UnityEngine.SpriteRenderer PurchasedOverlay;
    public UnityEngine.BoxCollider2D clickCollider;
    public PassiveButton PassiveButton;
    public TMPro.TextMeshPro NameText;
    public TMPro.TextMeshPro PriceText;
    public bool Purchased;
    public string Name;
    public string Price;
    public string ProductId;
    public UnityEngine.GameObject PriceLabel;
    public UnityEngine.SpriteRenderer LabelMask;
    public UnityEngine.SpriteRenderer LabelBackground;
    public UnityEngine.SpriteRenderer LabelGlass;
    public IBuyable Product;
    public System.Action onDestroy;
}
