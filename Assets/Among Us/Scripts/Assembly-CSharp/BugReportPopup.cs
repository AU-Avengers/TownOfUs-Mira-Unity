public class BugReportPopup : UnityEngine.MonoBehaviour
{
    public PassiveButton[] closeButtons;
    public PassiveButton submitButton;
    public DropdownButton categoryDropdown;
    public TextBoxTMP descriptionField;
    public PassiveButton descriptionFieldButton;
    public Checkbox attachScreenshotCheckbox;
    public TMPro.TextMeshPro descriptionCharacterCount;
    public TMPro.TextMeshPro submittedText;
    public UiElement backButton;
    public UiElement defaultButtonSelected;
    public bool descriptionEntered;
    public StringNames selectedCategory;
}
