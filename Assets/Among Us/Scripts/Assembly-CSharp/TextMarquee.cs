public class TextMarquee : UnityEngine.MonoBehaviour
{
    public TMPro.TextMeshPro Target;
    public UnityEngine.MeshRenderer[] allRenderers;
    public int lastChildCount;
    public string targetText;
    public float ScrollSpeed;
    public float PauseTime;
    public float AreaWidth;
    public bool IgnoreTextChanges;
}
