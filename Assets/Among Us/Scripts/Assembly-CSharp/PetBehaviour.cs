public class PetBehaviour : UnityEngine.MonoBehaviour
{
    public PetData data;
    public PowerTools.SpriteAnim animator;
    public UnityEngine.Rigidbody2D rigidbody;
    public UnityEngine.Collider2D collider;
    public float yOffset;
    public UnityEngine.Transform pettingHandPosition;
    public UnityEngine.AnimationClip idleClip;
    public UnityEngine.AnimationClip sadClip;
    public UnityEngine.AnimationClip scaredClip;
    public UnityEngine.AnimationClip walkClip;
    public UnityEngine.AnimationClip petClip;
    public UnityEngine.SpriteRenderer[] renderers;
    public UnityEngine.SpriteRenderer[] shadows;
    public PlayerControl targetPlayer;
    public bool visible;
    public bool flipX;
    public bool beingPet;
    public bool manualMoving;
}
