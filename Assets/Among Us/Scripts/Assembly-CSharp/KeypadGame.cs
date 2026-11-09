public class KeypadGame : Minigame
{
    public TMPro.TextMeshPro TargetText;
    public TMPro.TextMeshPro NumberText;
    public int number;
    public string numString;
    public bool animating;
    public UnityEngine.SpriteRenderer AcceptButton;
    public LifeSuppSystemType system;
    public NoOxyTask oxyTask;
    public bool done;
    public UiElement BackButton;
    public UiElement DefaultButtonSelected;
}
