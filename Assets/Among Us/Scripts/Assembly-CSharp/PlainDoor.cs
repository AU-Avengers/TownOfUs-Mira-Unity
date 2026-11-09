public class PlainDoor : OpenableDoor
{
    public bool Open;
    public UnityEngine.BoxCollider2D myCollider;
    public UnityEngine.Collider2D shadowCollider;
    public PowerTools.SpriteAnim animator;
    public UnityEngine.AnimationClip OpenDoorAnim;
    public UnityEngine.AnimationClip CloseDoorAnim;
    public UnityEngine.AudioClip OpenSound;
    public UnityEngine.AudioClip CloseSound;
    public float size;
}
