public class Asteroid : PoolableBehavior
{
    public UnityEngine.Sprite[] AsteroidImages;
    public UnityEngine.Sprite[] BrokenImages;
    public int imgIdx;
    public FloatRange MoveSpeed;
    public FloatRange RotateSpeed;
    public UnityEngine.SpriteRenderer Explosion;
}
