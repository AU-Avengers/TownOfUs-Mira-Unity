public class TakePartsMinigame : Minigame
{
    public PassiveButton[] parts;
    public UnityEngine.GameObject[] inventoryParts;
    public PassiveButton boxLid;
    public UnityEngine.GameObject boxOpen;
    public UnityEngine.GameObject hand;
    public UnityEngine.AudioClip openToolboxSfx;
    public UnityEngine.AudioClip[] pickUpSfx;
    public Controller controller;
    public int partsTaken;
}
