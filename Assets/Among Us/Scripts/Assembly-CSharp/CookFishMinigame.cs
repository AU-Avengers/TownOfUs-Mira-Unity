public class CookFishMinigame : Minigame
{
    public float cookingTimeSeconds;
    public CookableFish[] cookableFishes;
    public FungleTimer timer;
    public UnityEngine.GameObject taskArrow;
    public bool checkForTimerDone;
    public int controllerFishIndex;
    public UnityEngine.AudioClip onTimerDoneSfx;
    public enum State : int
    {
        NotCooking = 0,
        CookingSide1 = 1,
        CookingSide2 = 2,
}
}
