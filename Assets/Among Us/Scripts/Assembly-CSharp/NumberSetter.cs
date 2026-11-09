public class NumberSetter : UnityEngine.MonoBehaviour
{
    public NumberButton ButtonPrefab;
    public Scroller ButtonParent;
    public AgeGateScreen ParentAgeGateScreen;
    public float ButtonStart;
    public float ButtonHeight;
    public NumberButton[] AllButtons;
    public NumberMenu parentMenu;
    public NumberSetter dayNumberSetter;
    public NumberSetter.DateType dateType;
    public UiElement backButton;
    public UiElement defaultButton;
    public enum DateType : int
    {
        DAYS = 0,
        YEARS = 1,
        MONTHS = 2,
}
}
