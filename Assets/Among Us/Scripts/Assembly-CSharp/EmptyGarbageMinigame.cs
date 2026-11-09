public class EmptyGarbageMinigame : Minigame
{
    public FloatRange HandleRange;
    public Vector2Range SpawnRange;
    public UnityEngine.Collider2D Blocker;
    public UnityEngine.AreaEffector2D Popper;
    public UnityEngine.Collider2D Handle;
    public UnityEngine.SpriteRenderer Bars;
    public UnityEngine.Transform VibratePivot;
    public Controller controller;
    public bool finished;
    public int NumObjects;
    public UnityEngine.SpriteRenderer[] Objects;
    public UnityEngine.SpriteRenderer[] GarbagePrefabs;
    public UnityEngine.SpriteRenderer[] LeafPrefabs;
    public UnityEngine.SpriteRenderer[] SpecialObjectPrefabs;
    public UnityEngine.AudioClip LeverDown;
    public UnityEngine.AudioClip LeverUp;
    public UnityEngine.AudioClip GrinderStart;
    public UnityEngine.AudioClip GrinderLoop;
    public UnityEngine.AudioClip GrinderEnd;
    public TouchpadBehavior touchpad;
    public bool hadInput;
    public float leverInput;
    public UnityEngine.Coroutine popCoroutine;
    public UnityEngine.Coroutine animateCoroutine;
}
