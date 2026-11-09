public class CollectableOre : UnityEngine.MonoBehaviour
{
    public UnityEngine.SpriteRenderer spriteRenderer;
    public BreakableRock[] rocks;
    public UnityEngine.Sprite[] oreSprites;
    public UnityEngine.Sprite[] rockSprites;
    public UnityEngine.AudioClip gemCollect;
    public int rockCount;
    public System.Action onCollect;
    public bool isRock;
    public System.Action onRockRelease;
}
