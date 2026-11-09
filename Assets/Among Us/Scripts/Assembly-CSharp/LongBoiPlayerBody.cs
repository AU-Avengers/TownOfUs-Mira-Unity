public class LongBoiPlayerBody : UnityEngine.MonoBehaviour
{
    public UnityEngine.SpriteRenderer neckSprite;
    public UnityEngine.SpriteRenderer foregroundNeckSprite;
    public UnityEngine.SpriteRenderer headSprite;
    public PlayerControl myPlayerControl;
    public PoolablePlayer myPoolablePlayer;
    public CosmeticsLayer cosmeticLayer;
    public float neckHeadZPos;
    public float cosmeticYOffset;
    public bool isPoolablePlayer;
    public bool isExiledPlayer;
    public float targetHeight;
    public bool skipNeckAnim;
    public bool isSeekerHorse;
    public UnityEngine.GameObject neckHeadParent;
    public bool hideCosmeticsQC;
    public float growSpeed;
    public PlayerControl hideAndSeekImpostor;
    public float calculatedNeckHeight;
    public bool ShouldLongAround;
    public System.Single[] heightsPerColor;
}
