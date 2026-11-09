public class FreeplayPopoverButton : UnityEngine.MonoBehaviour
{
    public MapNames map;
    public UnityEngine.BoxCollider2D collider;
    public PassiveButton button;
    public System.Action<FreeplayPopoverButton> OnPressEvent;
}
