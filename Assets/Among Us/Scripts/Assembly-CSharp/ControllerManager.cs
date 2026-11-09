public class ControllerManager : UnityEngine.MonoBehaviour
{
    public bool inputDetectedLastFrame;
    public UnityEngine.GameObject PrefabMouseCursorForConsole;
    public UnityEngine.GameObject ConsoleMouse;
    public ControllerUiElementsState CurrentUiState;
    public float deltaSinceLastUiHighlight;
    public bool disabledVirtualCursor;
    public int frameDelaySinceInputChanged;
    public Logger logger;
    public string currentScene;
}
