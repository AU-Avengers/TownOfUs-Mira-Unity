public class HideAndSeekTimerBar : UnityEngine.MonoBehaviour
{
    public TMPro.TextMeshPro timeText;
    public UnityEngine.Transform timerBar;
    public UnityEngine.MeshRenderer timerBarRenderer;
    public UnityEngine.Transform chunkBar;
    public float targetBarSize;
    public bool freezeChunk;
    public UnityEngine.Coroutine chunkCoroutine;
}
