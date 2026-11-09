public class RaycastAmbientSoundPlayer : UnityEngine.MonoBehaviour
{
    public UnityEngine.AudioClip AmbientSound;
    public float AmbientVolume;
    public float AmbientMaxDist;
    public float HitModifier;
    public bool ShouldVibrate;
    public float ambientVolume;
    public float t;
    public UnityEngine.RaycastHit2D[] volumeBuffer;
}
