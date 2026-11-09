public class StowArms : Minigame
{
    public UnityEngine.GameObject GunContent;
    public UnityEngine.GameObject RifleContent;
    public UnityEngine.Transform selectorObject;
    public UnityEngine.GameObject[] selectorSubobjects;
    public UnityEngine.SpriteRenderer[] handSprites;
    public UnityEngine.AudioClip pickupGun;
    public UnityEngine.AudioClip placeGun;
    public UnityEngine.Collider2D[] GunColliders;
    public DragSlot[] GunsSlots;
    public UnityEngine.AudioClip pickupRifle;
    public UnityEngine.AudioClip placeRifle;
    public UnityEngine.Collider2D[] RifleColliders;
    public DragSlot[] RifleSlots;
    public Controller cont;
    public UnityEngine.Collider2D currentGrabbedObject;
    public UnityEngine.Vector3 grabOffset;
}
