public class SystemConsole : UnityEngine.MonoBehaviour, IUsable
{
    public ImageNames useIcon;
    public UnityEngine.Vector2 SafePositionLocal;
    public float usableDistance;
    public bool FreeplayOnly;
    public bool onlyFromBelow;
    public UnityEngine.SpriteRenderer Image;
    public Minigame MinigamePrefab;
    public void Use() { }
}
