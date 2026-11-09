public class TaskAdderGame : Minigame
{
    public TMPro.TextMeshPro PathText;
    public TaskFolder RootFolderPrefab;
    public TaskAddButton TaskPrefab;
    public UnityEngine.Transform TaskParent;
    public TaskAddButton RoleButton;
    public float folderWidth;
    public float fileWidth;
    public float lineWidth;
    public TaskFolder Root;
    public UiElement BackButton;
    public UiElement FolderBackButton;
    public string restorePreviousSelectionByFolderName;
    public UiElement restorePreviousSelectionFound;
}
