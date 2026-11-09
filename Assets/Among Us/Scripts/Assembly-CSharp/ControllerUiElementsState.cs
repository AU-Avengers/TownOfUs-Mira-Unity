[System.Serializable]
public class ControllerUiElementsState : System.Object
{
    public string MenuName;
    public UiElement CurrentSelection;
    public System.Collections.Generic.List<UiElement> SelectableUiElements;
    public UiElement BackButton;
    public bool EnforceGridNavigation;
    public float zPos;
    public bool IsScene;
}
