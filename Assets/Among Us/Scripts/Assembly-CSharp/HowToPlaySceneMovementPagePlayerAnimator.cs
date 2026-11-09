public class HowToPlaySceneMovementPagePlayerAnimator : UnityEngine.MonoBehaviour
{
    public float Speed;
    public VirtualJoystick joystick;
    public UnityEngine.SpriteRenderer UseButton;
    public HowToPlaySceneMovementPageFingerBehaviour finger;
    public UnityEngine.AnimationClip RunAnim;
    public UnityEngine.AnimationClip IdleAnim;
    public UnityEngine.Vector2 velocity;
    public int NearbyConsoles;
}
