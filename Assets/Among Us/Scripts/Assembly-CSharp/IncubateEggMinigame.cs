public class IncubateEggMinigame : Minigame
{
    public PassiveButton incubatorButton;
    public UnityEngine.SpriteRenderer egg;
    public float secondsToHatchEgg;
    public UnityEngine.GameObject incubatorLight;
    public UnityEngine.SpriteRenderer critter;
    public IncubateEggMinigameEmote happyEmote;
    public IncubateEggMinigameEmote thirstyEmote;
    public IncubateEggMinigameEmote hungryEmote;
    public PassiveButton foodBowl;
    public UnityEngine.GameObject food;
    public PassiveButton waterBottle;
    public UnityEngine.GameObject waterFull;
    public FungleTimer timer;
    public UnityEngine.GameObject emptyGlyphs;
    public UnityEngine.GameObject hatchedGlyphs;
    public UnityEngine.AudioClip foodPlacedSfx;
    public UnityEngine.AudioClip waterPlacedSfx;
    public UnityEngine.AudioClip eggPlacedSfx;
    public UnityEngine.AudioClip eggHatchSfx;
    public UnityEngine.AudioClip timerEndSfx;
    public float lastEmoteTime;
    public enum State : int
    {
        Empty = 0,
        EggPlaced = 1,
        EggHatched = 2,
        Complete = 3,
}
}
