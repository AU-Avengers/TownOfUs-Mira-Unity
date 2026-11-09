public class DraggablePartFixed : UnityEngine.MonoBehaviour
{
    public UnityEngine.Collider2D collider;
    public UnityEngine.Transform targetPoint;
    public UnityEngine.GameObject brokenPart;
    public UnityEngine.SpriteRenderer sprite;
    public UnityEngine.Color finalColor;
    public UnityEngine.Vector3 initialPosition;
    public UnityEngine.Vector3 initialScale;
    public System.Action OnNewPositionSavedEvent;
    public System.Action OnPartPositionResetEvent;
}
