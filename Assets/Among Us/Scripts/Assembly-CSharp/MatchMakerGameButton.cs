public class MatchMakerGameButton : PoolableBehavior, IConnectButton
{
    public TMPro.TextMeshPro NameText;
    public TMPro.TextMeshPro SmallNameText;
    public TMPro.TextMeshPro PlayerCountText;
    public TMPro.TextMeshPro ImpostorCountText;
    public UnityEngine.SpriteRenderer MapIcon;
    public PlatformIdentifier PlatformIdentifier;
    public TMPro.TextMeshPro LanguageText;
    public UnityEngine.Sprite[] MapIcons;
    public PowerTools.SpriteAnim connectIcon;
    public UnityEngine.AnimationClip connectClip;
    public InnerNet.GameListing myListing;
}
