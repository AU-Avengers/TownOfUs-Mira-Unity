public class PlacePartsMinigame : Minigame
{
    public DraggablePart[] draggableParts;
    public DraggablePartFixed[] draggableFixedParts;
    public UnityEngine.SpriteRenderer hand;
    public UnityEngine.Sprite openHand;
    public UnityEngine.Sprite closeHand;
    public Controller controller;
    public UnityEngine.AudioClip[] pickUpPartSfx;
    public UnityEngine.AudioClip[] resetPartSfx;
    public UnityEngine.AudioClip[] scrapOldPartSfx;
    public UnityEngine.AudioClip[] attachPartSfx;
    public DraggablePart selectedPart;
    public DraggablePartFixed selectedFixedPart;
    public int placedParts;
}
