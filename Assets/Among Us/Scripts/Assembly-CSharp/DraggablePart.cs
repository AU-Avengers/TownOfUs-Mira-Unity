public class DraggablePart : UnityEngine.MonoBehaviour
{
    public UnityEngine.Collider2D collider;
    public UnityEngine.SpriteRenderer targetSprite;
    public UnityEngine.Vector3 initialPosition;
    public System.Action OnNewPositionSavedEvent;
    public System.Action OnPartPositionResetEvent;
}
