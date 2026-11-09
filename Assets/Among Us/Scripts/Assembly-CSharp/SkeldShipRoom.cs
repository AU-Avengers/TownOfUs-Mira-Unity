public class SkeldShipRoom : PlainShipRoom, IStepWatcher
{
    public UnityEngine.AudioClip AmbientSound;
    public float AmbientVolume;
    public float AmbientMaxDist;
    public UnityEngine.Vector2 AmbientOffset;
    public SoundGroup FootStepSounds;
    public UnityEngine.RaycastHit2D[] volumeBuffer;
}
