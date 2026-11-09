public class WeaponsMinigame : Minigame
{
    public FloatRange XSpan;
    public FloatRange YSpan;
    public FloatRange TimeToSpawn;
    public ObjectPoolBehavior asteroidPool;
    public TMPro.TextMeshPro ScoreText;
    public UnityEngine.SpriteRenderer TargetReticle;
    public UnityEngine.LineRenderer TargetLines;
    public UnityEngine.Vector3 TargetCenter;
    public UnityEngine.Collider2D BackgroundCol;
    public UnityEngine.SpriteRenderer Background;
    public Controller myController;
    public float Timer;
    public UnityEngine.AudioClip ShootSound;
    public UnityEngine.AudioClip[] ExplodeSounds;
}
