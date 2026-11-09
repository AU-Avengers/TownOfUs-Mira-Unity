public class DangerMeter : UnityEngine.MonoBehaviour
{
    public UnityEngine.SpriteRenderer[] barSprites;
    public UnityEngine.SpriteRenderer crewmateSeekerSprite;
    public UnityEngine.Color emptyColor;
    public UnityEngine.Color safeColor;
    public UnityEngine.Color cautionColor;
    public UnityEngine.Color dangerColor;
    public UnityEngine.Vector3 originalLocalPosition;
    public UnityEngine.Coroutine shakeCoroutine;
}
