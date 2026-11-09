public class CollectableShell : UnityEngine.MonoBehaviour
{
    public UnityEngine.SpriteRenderer shellSprite;
    public PassiveButton[] sands;
    public UnityEngine.AudioClip[] shellSounds;
    public System.Action onSandCleared;
    public UnityEngine.SpriteRenderer[] sandSprites;
    public bool isCollected;
}
