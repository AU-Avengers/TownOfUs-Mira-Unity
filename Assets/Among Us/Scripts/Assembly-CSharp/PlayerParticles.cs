public class PlayerParticles : UnityEngine.MonoBehaviour
{
    public PlayerParticleInfo[] Sprites;
    public PlayerParticleInfo[] HorseSprites;
    public FloatRange velocity;
    public FloatRange scale;
    public ObjectPoolBehavior pool;
    public float StartRadius;
    public PoolableBehavior HorsePrefab;
    public UnityEngine.Camera FollowCamera;
}
