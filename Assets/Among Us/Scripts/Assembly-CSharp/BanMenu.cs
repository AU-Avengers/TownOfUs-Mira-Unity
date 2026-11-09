public class BanMenu : UnityEngine.MonoBehaviour
{
    public BanButton BanButtonPrefab;
    public UnityEngine.SpriteRenderer Background;
    public PassiveButton MenuButton;
    public UnityEngine.SpriteRenderer BanButton;
    public UnityEngine.SpriteRenderer KickButton;
    public UnityEngine.SpriteRenderer ReportButton;
    public UnityEngine.GameObject ContentParent;
    public ReportReasonScreen ReportReason;
    public int selectedClientId;
    public float backgroundTailWidth;
    public float backgroundBaseWidth;
    public float backgroundBaseHeight;
    public float borderPadding;
    public float heightPerButton;
    public float widthPerCol;
    public UiElement BackButton;
    public UiElement DefaultButtonSelected;
}
