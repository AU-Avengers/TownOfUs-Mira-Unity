public class ManualDoor : SomeKindaDoor
{
    public bool Opening;
    public UnityEngine.BoxCollider2D myCollider;
    public UnityEngine.Collider2D shadowCollider;
    public UnityEngine.SpriteRenderer image;
    public float size;
    public float OpenDuration;
    public float openTimer;
    public float openValue;
    public UnityEngine.AudioClip OpenSound;
    public UnityEngine.AudioClip CloseSound;
}
