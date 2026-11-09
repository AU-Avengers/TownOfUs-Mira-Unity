public class TriggeredSound : UnityEngine.MonoBehaviour
{
    public UnityEngine.AudioClip[] SoundToPlay;
    public FloatRange PitchRange;
    public UnityEngine.AudioSource Player;
    public float MaxVolume;
    public float MaxDist;
    public float HitModifier;
    public UnityEngine.RaycastHit2D[] volumeBuffer;
}
