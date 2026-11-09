public class ReportReasonScreen : UnityEngine.MonoBehaviour
{
    public BanMenu Parent;
    public ButtonRolloverHandler[] Buttons;
    public TMPro.TextMeshPro NameText;
    public UnityEngine.SpriteRenderer PlayerIcon;
    public System.Nullable<InnerNet.ReportReasons> currentReason;
    public ReportNotification ConfirmScreen;
    public string playerName;
    public int colorId;
}
