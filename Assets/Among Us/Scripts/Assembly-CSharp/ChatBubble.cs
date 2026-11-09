public class ChatBubble : PoolableBehavior
{
    public PoolablePlayer Player;
    public UnityEngine.SpriteRenderer Xmark;
    public UnityEngine.SpriteRenderer votedMark;
    public TMPro.TextMeshPro NameText;
    public TMPro.TextMeshPro TextArea;
    public UnityEngine.SpriteRenderer Background;
    public UnityEngine.SpriteRenderer MaskArea;
    public PlatformIdentifier PlatformIcon;
    public TMPro.TextMeshPro ColorBlindName;
    public GameData.PlayerInfo playerInfo;
    public int maskLayer;
}
