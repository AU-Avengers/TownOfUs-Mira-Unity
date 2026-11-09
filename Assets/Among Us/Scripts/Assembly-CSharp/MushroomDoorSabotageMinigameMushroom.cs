public class MushroomDoorSabotageMinigameMushroom : UnityEngine.MonoBehaviour
{
    public PassiveButton button;
    public UnityEngine.SpriteRenderer sprite;
    public UnityEngine.ParticleSystem whackedEffect;
    public UnityEngine.AudioClip mushroomAppearSFX;
    public UnityEngine.AudioClip mushroomDisappearSFX;
    public UnityEngine.AudioClip mushroomHitSFX;
    public float timeInState;
    public System.Action<MushroomDoorSabotageMinigameMushroom> OnClick;
    public enum State : int
    {
        None = 0,
        Visible = 1,
        Invisible = 2,
        Appearing = 3,
        Disappearing = 4,
        Whacked = 5,
}
}
