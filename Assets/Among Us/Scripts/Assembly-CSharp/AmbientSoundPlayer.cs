public class AmbientSoundPlayer : UnityEngine.MonoBehaviour
{
    public UnityEngine.AudioClip AmbientSound;
    public UnityEngine.Collider2D[] HitAreas;
    public float MaxVolume;
    public float DistanceFallOff;
    public float FallOffRate;
    public bool useMuffled;
}
