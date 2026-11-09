public class NoShadowBehaviour : UnityEngine.MonoBehaviour
{
    public UnityEngine.Renderer rend;
    public bool didHit;
    public UnityEngine.Renderer shadowChild;
    public UnityEngine.Collider2D hitOverride;
    public UnityEngine.BoxCollider2D bc;
    public bool isBox;
    public bool verticalBox;
    public UnityEngine.Vector2[] boxCheckPoints;
}
