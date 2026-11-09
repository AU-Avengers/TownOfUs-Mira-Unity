public class Mushroom : UnityEngine.MonoBehaviour
{
    public UnityEngine.Collider2D mushroomCollider;
    public UnityEngine.SpriteRenderer mushroom;
    public UnityEngine.SpriteRenderer spores;
    public UnityEngine.GameObject sporeMask;
    public int id;
    public PowerTools.SpriteAnim mushroomAnimator;
    public UnityEngine.AnimationClip mushroomIdle;
    public UnityEngine.AnimationClip mushroomAppear;
    public UnityEngine.AnimationClip mushroomSteppedOn;
    public PowerTools.SpriteAnim sporeCloudAnimator;
    public PowerTools.SpriteAnim sporeCloudMaskAnimator;
    public UnityEngine.AnimationClip sporeCloudIdle;
    public UnityEngine.AnimationClip sporeCloudAppear;
    public UnityEngine.AnimationClip sporeCloudDisappear;
    public float secondsBetweenSporeReleases;
    public float secondsSporeIsActive;
    public float secondsSporeReappearsFor;
    public float secondsSporeFade;
    public UnityEngine.AudioClip spawnSound;
    public UnityEngine.AudioClip activateSporeSound;
    public UnityEngine.ContactFilter2D filter;
    public UnityEngine.Vector3 origPosition;
}
