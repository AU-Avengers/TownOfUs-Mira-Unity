[System.Serializable]
public class PlayerBodySprite : System.Object
{
    public UnityEngine.SpriteRenderer BodySprite;
    public UnityEngine.SpriteRenderer[] LongModeParts;
    public PlayerPettingHand PettingHand;
    public UnityEngine.SpriteRenderer HandHat;
    public UnityEngine.Sprite GhostSprite;
    public UnityEngine.Sprite[] ExtraGhostSprites;
    public PlayerBodyTypes Type;
    public UnityEngine.Vector3 flippedCosmeticOffset;
    public UnityEngine.Vector3 normalCosmeticOffset;
}
