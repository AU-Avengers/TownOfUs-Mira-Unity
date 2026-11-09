public class PhotosMinigame : Minigame
{
    public GamePhotoBehaviour[] photos;
    public UnityEngine.Sprite[] PhotoContents;
    public UnityEngine.Collider2D PoolHitbox;
    public UnityEngine.Transform selectorObject;
    public UnityEngine.SpriteRenderer selectorHand;
    public UnityEngine.Rect PolaroidBounds;
    public Controller controller;
    public bool prevHadButton;
    public int currentlyGrabbedObject;
}
