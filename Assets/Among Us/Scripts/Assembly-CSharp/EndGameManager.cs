public class EndGameManager : UnityEngine.MonoBehaviour
{
    public TMPro.TextMeshPro WinText;
    public UnityEngine.MeshRenderer BackgroundBar;
    public UnityEngine.MeshRenderer Foreground;
    public FloatRange ForegroundRadius;
    public UnityEngine.SpriteRenderer FrontMost;
    public PoolablePlayer PlayerPrefab;
    public UnityEngine.Sprite GhostSprite;
    public UnityEngine.AudioClip DisconnectStinger;
    public UnityEngine.AudioClip CrewStinger;
    public UnityEngine.AudioClip ImpostorStinger;
    public EndGameNavigation Navigation;
    public float stingerTime;
}
