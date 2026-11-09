public class ZiplineConsole : UnityEngine.MonoBehaviour, IUsableCoolDown, IUsable
{
    public float usableDistance;
    public UnityEngine.SpriteRenderer image;
    public ZiplineBehaviour zipline;
    public bool atTop;
    public ZiplineConsole destination;
    public void Use() { }
}
