public class PlayerVoteArea : UnityEngine.MonoBehaviour
{
    public System.Byte TargetPlayerId;
    public UnityEngine.GameObject Buttons;
    public UiElement ConfirmButton;
    public UiElement CancelButton;
    public UiElement PlayerButton;
    public UnityEngine.SpriteRenderer Background;
    public UnityEngine.SpriteRenderer MaskArea;
    public UnityEngine.SpriteRenderer Flag;
    public UnityEngine.SpriteRenderer Megaphone;
    public UnityEngine.SpriteRenderer Overlay;
    public UnityEngine.SpriteRenderer XMark;
    public UnityEngine.SpriteRenderer GAIcon;
    public UnityEngine.SpriteRenderer ThumbsDown;
    public UnityEngine.SpriteRenderer HighlightedFX;
    public TMPro.TextMeshPro NameText;
    public TMPro.TextMeshPro LevelNumberText;
    public TMPro.TextMeshPro ColorBlindName;
    public bool AnimateButtonsFromLeft;
    public bool AmDead;
    public bool DidReport;
    public System.Byte VotedFor;
    public bool voteComplete;
    public bool resultsShowing;
    public PoolablePlayer PlayerIcon;
}
