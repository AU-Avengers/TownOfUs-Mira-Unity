public class BuildSandcastleMinigame : Minigame
{
    public float liftLerpSpeed;
    public float fallGravity;
    public UnityEngine.Transform startPosition;
    public UnityEngine.Transform endPosition;
    public UnityEngine.Collider2D bucketCollider;
    public UnityEngine.SpriteRenderer bucketSprite;
    public UnityEngine.SpriteRenderer bucketBackSprite;
    public UnityEngine.GameObject bucketGlyph;
    public UnityEngine.AudioClip grabSound;
    public UnityEngine.AudioClip completeSound;
    public Controller controller;
    public bool hasInput;
    public float fallVelocity;
    public float targetBucketY;
    public float trueBucketY;
}
