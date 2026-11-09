public class DropdownButton : UnityEngine.MonoBehaviour
{
    public float buttonStartY;
    public float buttonHeight;
    public UnityEngine.GameObject optionsScreen;
    public PassiveButton openOptionsButton;
    public PassiveButton closeButton;
    public TMPro.TextMeshPro buttonText;
    public UnityEngine.Collider2D clickMask;
    public ObjectPoolBehavior optionPool;
    public System.Action<System.Int32> onOptionSelect;
}
