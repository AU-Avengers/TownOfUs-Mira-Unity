public class FriendsListUI : UnityEngine.MonoBehaviour
{
    public TMPro.TextMeshPro FriendCodeText;
    public UnityEngine.SpriteRenderer FriendCodeHiddenIcon;
    public UnityEngine.GameObject FriendCodeHideToggleObject;
    public FriendsListUI.FriendsListTabButton[] Tabs;
    public UnityEngine.GameObject NotifArea;
    public UnityEngine.GameObject BlockedArea;
    public UnityEngine.GameObject FriendArea;
    public UnityEngine.GameObject PlatformFriendArea;
    public UnityEngine.GameObject LobbyPlayerArea;
    public UnityEngine.GameObject RecentlyPlayedArea;
    public UnityEngine.GameObject LobbyPlayersTab;
    public UnityEngine.GameObject LobbyPlayersInactiveTab;
    public UnityEngine.GameObject PlatformFriendsButton;
    public FriendRequestBar FriendRequestBar;
    public BlockedPlayerBar BlockedPlayerBar;
    public OnlineFriendBar OnlineFriendBar;
    public OnlineFriendBar PlatformFriendBar;
    public LobbyPlayerBar LobbyPlayerBar;
    public LobbyInviteBar LobbyInviteBar;
    public Scroller FriendsScroller;
    public Scroller PlatformFriendsScroller;
    public Scroller BlockedScroller;
    public Scroller NotifScroller;
    public Scroller LobbyScroller;
    public Scroller RecentlyPlayedScroller;
    public UnityEngine.SpriteRenderer InactiveAllFriends;
    public UnityEngine.SpriteRenderer InactivePlatformFriends;
    public TextBoxTMP AddFriendArea;
    public float YStart;
    public float YOffset;
    public UnityEngine.SpriteRenderer ViewRequestsButton;
    public TMPro.TextMeshPro ViewRequestsText;
    public UnityEngine.Color NewRequestColor;
    public UnityEngine.Color NoRequestsColor;
    public UnityEngine.GameObject AddFriendObjects;
    public UiElement BackButton;
    public UiElement DefaultButtonSelected;
    public UnityEngine.GameObject glyphL;
    public UnityEngine.GameObject glyphR;
    public int selectedTab;
    public string friendCodeHiddenText;
    public bool viewingAllFriends;
    public string currentSceneName;
    public float addFriendCooldown;
    [System.Serializable]
    public class FriendsListTabButton : System.Object
    {
        public FriendsListUI.FriendsListTab tab;
        public UnityEngine.GameObject tabObject;
        public System.Collections.Generic.List<UnityEngine.SpriteRenderer> selectedSprites;
        public bool selectable;
}
    public enum FriendsListTab : int
    {
        LobbyPlayers = 0,
        RecentPlayers = 1,
        AmongUsFriends = 2,
        Blocked = 3,
        Notifications = 4,
        AddFriend = 5,
}
}
