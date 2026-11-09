public class GameStartManager : DestroyableSingleton, IDisconnectHandler
{
    public int MinPlayers;
    public TMPro.TextMeshPro PlayerCounter;
    public int LastPlayerCount;
    public UnityEngine.GameObject GameSizePopup;
    public UnityEngine.GameObject GameRoomButton;
    public TMPro.TextMeshPro GameRoomNameInfo;
    public TMPro.TextMeshPro GameRoomNameCode;
    public LobbyBehaviour LobbyPrefab;
    public TMPro.TextMeshPro GameStartText;
    public TMPro.TextMeshPro startLabelText;
    public UnityEngine.SpriteRenderer StartButton;
    public ActionMapGlyphDisplay StartButtonGlyph;
    public UnityEngine.GameObject StartButtonGlyphContainer;
    public UnityEngine.SpriteRenderer MakePublicButton;
    public ControllerHeldButtonBehaviour MakePublicButtonBehaviour;
    public UnityEngine.GameObject MakePublicButtonGlyph;
    public UnityEngine.Sprite PublicGameImage;
    public UnityEngine.Sprite PrivateGameImage;
    public TMPro.TextMeshPro privatePublicText;
    public UnityEngine.SpriteRenderer ShareOnDiscordButton;
    public UnityEngine.GameObject InviteFriendsButton;
    public GameStartManager.StartingStates startState;
    public float countDownTimer;
    public ImageTranslator publicButtonTranslator;
    public enum StartingStates : int
    {
        NotStarting = 0,
        Countdown = 1,
        Starting = 2,
}
}
