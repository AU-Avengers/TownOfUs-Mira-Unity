public class CookableFish : UnityEngine.MonoBehaviour
{
    public PassiveButton button;
    public UnityEngine.SpriteRenderer outline;
    public UnityEngine.SpriteRenderer cookingFish;
    public UnityEngine.Sprite rawFish;
    public UnityEngine.Sprite cookedFish;
    public UnityEngine.GameObject glyphActionGO;
    public UnityEngine.AudioClip onGrillSfx;
    public UnityEngine.AudioClip onFlipSfx;
    public UnityEngine.AudioClip onFinishCookingSfx;
    public System.Action additionalOnClick;
    public enum State : int
    {
        FishNotPlaced = 0,
        FishPlaced = 1,
        OtherSideCooking = 2,
        Finished = 3,
}
}
