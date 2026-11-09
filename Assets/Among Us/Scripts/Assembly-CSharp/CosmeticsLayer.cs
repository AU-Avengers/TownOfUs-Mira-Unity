public class CosmeticsLayer : UnityEngine.MonoBehaviour
{
    public System.Action<System.Int32> OnColorChange;
    public System.Action OnSetBodyAsGhost;
    public System.Action<System.String,System.Int32,CosmeticsLayer.CosmeticKind> OnCosmeticSet;
    public bool alwaysDrawNormalPlayer;
    public bool uiPet;
    public float zIndexSpacing;
    public bool showColorBlindText;
    public TMPro.TextMeshPro colorBlindText;
    public HatParent hat;
    public TMPro.TextMeshPro nameText;
    public UnityEngine.GameObject nameTextContainer;
    public UnityEngine.Transform petParent;
    public SkinLayer skin;
    public VisorLayer visor;
    public UnityEngine.Vector3 defaultHatVisorPosition;
    public PlayerBodyTypes bodyType;
    public PlayerMaterial.Properties bodyMatProperties;
    public PlayerBodySprite currentBodySprite;
    public PetBehaviour currentPet;
    public PlayerBodySprite normalBodySprite;
    public bool initialized;
    public LongBoiPlayerBody longboi;
    public bool visible;
    public bool isNameVisible;
    public bool lockVisible;
    public bool localPlayer;
    public enum CosmeticKind : int
    {
        SKIN = 0,
        HAT = 1,
        VISOR = 2,
        PET = 3,
}
}
