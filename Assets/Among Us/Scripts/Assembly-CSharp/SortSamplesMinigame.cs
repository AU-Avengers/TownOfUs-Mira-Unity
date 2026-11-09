public class SortSamplesMinigame : Minigame
{
    public SortableSample[] sortableSamples;
    public UnityEngine.Collider2D mushroomJar;
    public UnityEngine.Transform mushroomJarDropSpot;
    public UnityEngine.Collider2D crystalJar;
    public UnityEngine.Transform crystalJarDropSpot;
    public UnityEngine.Transform hand;
    public UnityEngine.SpriteRenderer handOpenSprite;
    public UnityEngine.SpriteRenderer handClosedSprite;
    public Controller controller;
    public SortableSample currentSample;
    public int samplesSorted;
}
