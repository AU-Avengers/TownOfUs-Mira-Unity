public class FriendsListManager : DestroyableSingleton
{
    public Steamworks.Callback<Steamworks.GameRichPresenceJoinRequested_t> m_GameRichPresenceJoinRequested;
    public JoinGameButton joinGameButton;
    public FriendListNotification FriendListNotification;
    public FriendsListConfirmMenu ConfirmationScreen;
    public FriendsListUI Ui;
    public FriendsListButton FriendsListButton;
    public UnityEngine.SpriteRenderer LoadScreen;
    public bool FriendCodeHidden;
    public UnityEngine.Sprite GlobalPlayerIcon;
    public Logger logger;
    public UnityEngine.Coroutine pollingRoutine;
    public bool gotFriendRequests;
    public bool gotLobbyInvites;
    public FriendsListConfirmMenu ConfirmationScreenPrefab;
    public FriendsListUI UiPrefab;
    public FriendsListButton FriendsListButtonPrefab;
    public class PlatformFriend : System.Object
    {
        public string Username;
        public System.UInt64 GUID;
        public Steamworks.CSteamID CSteamID;
}
}
