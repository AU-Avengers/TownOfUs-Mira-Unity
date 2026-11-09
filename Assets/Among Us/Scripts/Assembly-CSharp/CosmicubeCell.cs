public class CosmicubeCell : UnityEngine.MonoBehaviour
{
    public CosmicubeCell parent;
    public CosmicubeCell northChild;
    public CosmicubeCell southChild;
    public CosmicubeCell eastChild;
    public CosmicubeCell westChild;
    public UnityEngine.SpriteRenderer icon;
    public TMPro.TextMeshPro costText;
    public UnityEngine.SpriteRenderer cellSprite;
    public UnityEngine.SpriteRenderer qualitySprite;
    public UnityEngine.SpriteRenderer glowSprite;
    public UnityEngine.SpriteRenderer MaskArea;
    public UnityEngine.SpriteRenderer SelectionHighlight;
    public UnityEngine.GameObject data;
    public bool unlocked;
    public PowerTools.SpriteAnim Animator;
    public UnityEngine.AnimationClip PurchaseAnimation;
    public UnlockableCosmetic cosmetic;
    public UnityEngine.Material iconMaterial;
    public UnityEngine.Material iconColoredMaterial;
    public UnityEngine.Material maskMaterial;
    public CosmicubeMenu menu;
}
