public class FriendListNotification : UnityEngine.MonoBehaviour
{
    public UnityEngine.SpriteRenderer Icon;
    public TMPro.TextMeshPro Text;
    public float timeOnScreen;
    public enum IconType : int
    {
        Friend = 0,
        Block = 1,
        LobbyInvite = 2,
        Failed = 3,
        Sent = 4,
}
}
