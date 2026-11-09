public class MapBehaviour : UnityEngine.MonoBehaviour
{
    public AlphaPulse ColorControl;
    public UnityEngine.SpriteRenderer HerePoint;
    public UnityEngine.SpriteRenderer TrackedHerePoint;
    public MapCountOverlay countOverlay;
    public InfectedOverlay infectedOverlay;
    public MapTaskOverlay taskOverlay;
    public UnityEngine.GameObject fadedBackground;
    public SpecialInputHandler specialInputHandler;
    public bool countOverlayAllowsMovement;
    public System.Nullable<UnityEngine.Vector3> preMeetingPosition;
}
