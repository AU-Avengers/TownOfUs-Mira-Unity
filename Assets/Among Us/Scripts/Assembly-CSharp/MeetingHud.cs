public class MeetingHud : InnerNet.InnerNetObject, IDisconnectHandler
{
    public UnityEngine.SpriteRenderer BlackBackground;
    public UnityEngine.SpriteRenderer[] OuterMasks;
    public UnityEngine.SpriteRenderer[] PlayerColoredParts;
    public MeetingIntroAnimation MeetingIntro;
    public UnityEngine.Transform ButtonParent;
    public TMPro.TextMeshPro TitleText;
    public UnityEngine.Vector3 VoteOrigin;
    public UnityEngine.Vector3 VoteButtonOffsets;
    public PlayerVoteArea SkipVoteButton;
    public PlayerVoteArea[] playerStates;
    public PlayerVoteArea PlayerButtonPrefab;
    public UnityEngine.SpriteRenderer PlayerVotePrefab;
    public UnityEngine.Sprite CrackedGlass;
    public UnityEngine.SpriteRenderer Glass;
    public PassiveButton ProceedButton;
    public UnityEngine.AudioClip VoteSound;
    public UnityEngine.AudioClip VoteLockinSound;
    public UnityEngine.AudioClip VoteEndingSound;
    public UnityEngine.Transform meetingContents;
    public MeetingHud.VoteStates state;
    public UnityEngine.GameObject SkippedVoting;
    public UnityEngine.SpriteRenderer HostIcon;
    public GameData.PlayerInfo exiledPlayer;
    public bool wasTie;
    public TMPro.TextMeshPro TimerText;
    public float discussionTimer;
    public System.Byte reporterId;
    public bool amDead;
    public float resultsStartedAt;
    public int lastSecond;
    public Logger logger;
    public UiElement DefaultButtonSelected;
    public UiElement ProceedButtonUi;
    public enum VoteStates : int
    {
        Animating = 0,
        Discussion = 1,
        NotVoted = 2,
        Voted = 3,
        Results = 4,
        Proceeding = 5,
}
}
