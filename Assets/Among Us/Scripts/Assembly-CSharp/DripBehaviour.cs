public class DripBehaviour : UnityEngine.MonoBehaviour
{
    public Vector2Range SpawnArea;
    public FloatRange FirstWait;
    public FloatRange Frequency;
    public PowerTools.SpriteAnim myAnim;
    public UnityEngine.Collider2D[] IgnoreAreas;
    public bool FixDepth;
}
