public class MushroomWallDoor : OpenableDoor
{
    public UnityEngine.BoxCollider2D wallCollider;
    public UnityEngine.Collider2D shadowColl;
    public MushroomWallMushroom[] mushrooms;
    public UnityEngine.AudioClip openSound;
    public UnityEngine.AudioClip closeSound;
    public bool open;
    public bool allowAudio;
}
