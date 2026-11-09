public class SelectableHyperLink : UnityEngine.MonoBehaviour, ITextPart
{
    public SelectableHyperLink parentHyperlink;
    public UiElement HyperLink;
    public string selectedColor;
    public string unselectedColor;
    public System.Action onNewSelection;
    public string hyperLinkText;
    public string hyperLinkUrl;
    public string fullHyperLinkText;
}
