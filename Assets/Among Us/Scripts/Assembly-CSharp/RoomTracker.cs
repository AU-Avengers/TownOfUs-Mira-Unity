public class RoomTracker : UnityEngine.MonoBehaviour
{
    public TMPro.TextMeshPro text;
    public float SourceY;
    public float TargetY;
    public UnityEngine.Collider2D playerCollider;
    public UnityEngine.ContactFilter2D filter;
    public UnityEngine.Collider2D[] buffer;
    public PlainShipRoom LastRoom;
    public UnityEngine.Coroutine slideInRoutine;
}
