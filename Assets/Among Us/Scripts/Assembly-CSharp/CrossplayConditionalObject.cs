public class CrossplayConditionalObject : UnityEngine.MonoBehaviour
{
    public bool onlyOnPlayStation;
    public CrossplayConditionalObject.CrossplayConditionalType crossplayConditionalType;
    public enum CrossplayConditionalType : int
    {
        ShowIfCrossplayEnabled = 0,
        HideIfCrossplayEnabled = 1,
}
}
