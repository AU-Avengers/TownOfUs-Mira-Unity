public class CollectVegetablesMinigame : Minigame
{
    public float navigationDelay;
    public CollectableVegetable[] collectables;
    public UnityEngine.AudioClip selectionChangedSfx;
    public int selection;
    public int collected;
    public float lastNavigationTime;
    public enum Vegetable : int
    {
        Carrot = 0,
        Cauliflower = 1,
        Chard = 2,
        Curls = 3,
}
}
