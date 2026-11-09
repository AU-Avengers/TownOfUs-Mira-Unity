public class SortMinigame : Minigame
{
    public SortGameObject[] Objects;
    public UnityEngine.BoxCollider2D AnimalBox;
    public UnityEngine.BoxCollider2D PlantBox;
    public UnityEngine.BoxCollider2D MineralBox;
    public UnityEngine.AudioClip[] PickUpSounds;
    public UnityEngine.AudioClip[] DropSounds;
    public Controller myController;
    public UnityEngine.Transform selectorObject;
    public UnityEngine.SpriteRenderer selectorHand;
    public bool prevHadButton;
    public int currentlyGrabbedObject;
}
