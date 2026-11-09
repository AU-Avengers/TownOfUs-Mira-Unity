public class SortGameObject : UnityEngine.MonoBehaviour
{
    public SortGameObject.ObjType MyType;
    public UnityEngine.Collider2D Collider;
    public UnityEngine.SpriteRenderer Image;
    public UnityEngine.SpriteRenderer Shadow;
    public enum ObjType : int
    {
        Plant = 0,
        Mineral = 1,
        Animal = 2,
}
}
