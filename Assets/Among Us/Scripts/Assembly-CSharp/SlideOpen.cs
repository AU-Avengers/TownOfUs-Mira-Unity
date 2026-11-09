public class SlideOpen : UnityEngine.MonoBehaviour
{
    public float duration;
    public UnityEngine.UI.Button.ButtonClickedEvent OnClose;
    public UnityEngine.Camera parentCam;
    public UnityEngine.Vector3 openPosition;
    public UnityEngine.Vector3 closedPosition;
    public bool isOpen;
    public UnityEngine.GameObject subMenu;
    public UnityEngine.Vector3 computedClosedPosition;
}
