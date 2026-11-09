public class ButtonRolloverHandler : UnityEngine.MonoBehaviour
{
    public UnityEngine.SpriteRenderer Target;
    public UnityEngine.SpriteRenderer Target2;
    public TMPro.TextMeshPro TargetText;
    public UnityEngine.MeshRenderer TargetMesh;
    public UnityEngine.Color OverColor;
    public UnityEngine.Color OutColor;
    public UnityEngine.Color UnselectedColor;
    public bool UseObjectsOutColor;
    public bool UseObjectSelected;
    public UnityEngine.AudioClip HoverSound;
}
