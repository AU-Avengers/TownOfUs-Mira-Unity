public class MeshAnimator : UnityEngine.MonoBehaviour
{
    public UnityEngine.MeshFilter filter;
    public UnityEngine.Mesh[] Frames;
    public float frameRate;
    public float timer;
    public int frameId;
    public UnityEngine.Vector3 originalPosition;
    public UnityEngine.Vector3 originalScale;
    public MeshSequence sequence;
}
