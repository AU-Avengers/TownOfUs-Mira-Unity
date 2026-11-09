public class EOSManager : DestroyableSingleton
{
    public Steamworks.CallResult<Steamworks.EncryptedAppTicketResponse_t> OnEncryptedAppTicketResponseCallResult;
    public System.Action onLoginFailedCallback;
    public string productName;
    public string productVersion;
    public string productId;
    public string sandboxId;
    public string deploymentId;
    public string clientId;
    public string clientSecret;
    public string friendCode;
    public bool hasRunLoginFlow;
    public float platformTickTimer;
    public bool platformInitialized;
    public bool loginFlowFinished;
    public bool tryingToLogin;
    public bool stopTimeOutCheck;
    public UnityEngine.GameObject TimeOutPopup;
    public float TimeOutTime;
    public bool FinishedAssets;
    public bool announcementsVisible;
    public bool attemptAuthAgain;
    public System.UInt32 numLinkedAccounts;
    public EditAccountUsername editAccountUsername;
    public AskToMergeGuest askToMergeAccount;
    public string freeChatKey;
    public string customNameKey;
    public string friendsListKey;
    public string accountLinkKey;
    public UnityEngine.GameObject watermarkCanvas;
    public Logger logger;
    public int ageOfConsent;
    public string kwsUserId;
    public bool isKWSMinor;
    public string exchangeToken;
    public string platformAuthToken;
    public System.DateTime serverTimeOnLaunch;
    public bool authExpiredCallbackTriggered;
    public bool silentLoginFailed;
    public bool isRedeemingDLC;
    public enum AccountLoginStatus : int
    {
        Offline = 0,
        LoggedIn = 1,
        WaitingForParent = 2,
        TempAccount = 3,
}
    public enum EOS_ERRORS : int
    {
        FailedEpicAuthToken = 0,
        UnsupportedPlatform = 1,
        LinkAccountFail = 2,
        SteamworksAppTicketFail = 3,
        SteamworksAuthFail = 4,
        iOSAuthFail = 5,
        GoogleAuthFail = 6,
        GoogleAuthNoToken = 7,
        NullContinuanceToken = 8,
        MismatchedProductUserIDs = 9,
        GenericLoginError = 10,
        XboxUserAddError = 11,
        XboxGetTokenError = 12,
        AccountCreationFail = 13,
        InterfaceInitFail = 14,
        InvalidParentEmail = 15,
        GuestModeAuthFail = 16,
        PlatformNotSupported = 17,
        NintendoAuthFailed = 18,
        PlayStationAuthFailed = 19,
        AccountLinkFail = 20,
        NoConnectionError = 21,
        ItchIOAuthFail = 22,
        UnlinkAccountFail = 23,
        FriendCodeFail = 24,
        TempAccountError = 25,
}
}
