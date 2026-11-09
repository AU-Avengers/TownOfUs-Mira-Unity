public class FriendsListBar : UnityEngine.MonoBehaviour
{
    public TMPro.TextMeshPro SenderName;
    public InnerNet.ClientData ClientData;
    public UnityEngine.SpriteRenderer InactiveSprite;
    public PlatformIdentifier PlatformIdentifier;
    public FriendsListManager.PlatformFriend PlatformFriendData;
    public PassiveButton PlatformProfileButton;
    public float actionCooldown;
    public string puid;
    public string friendCode;
    public FriendsListUI parentUI;
}
