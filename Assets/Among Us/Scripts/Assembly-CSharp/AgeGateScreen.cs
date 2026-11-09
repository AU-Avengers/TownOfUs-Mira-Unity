public class AgeGateScreen : UnityEngine.MonoBehaviour
{
    public UnityEngine.GameObject EnterDateScreen;
    public UnityEngine.GameObject MoreInfoScreen;
    public UnityEngine.GameObject VerifyScreen;
    public UnityEngine.Color DefaultColor;
    public UnityEngine.Color FilledColor;
    public TMPro.TextMeshPro privacyInfoText;
    public TMPro.TextMeshPro monthText;
    public TMPro.TextMeshPro dayText;
    public TMPro.TextMeshPro yearText;
    public TMPro.TextMeshPro fullDateText;
    public string defaultMonthText;
    public string defaultDayText;
    public string defaultYearText;
    public int Day;
    public int Month;
    public int Year;
    public UiElement BackButton;
    public UiElement DefaultSelection;
}
