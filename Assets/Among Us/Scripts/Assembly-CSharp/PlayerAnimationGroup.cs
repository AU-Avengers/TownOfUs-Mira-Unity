[System.Serializable]
public class PlayerAnimationGroup : System.Object
{
    public PlayerBodyTypes BodyType;
    public PowerTools.SpriteAnim SpriteAnimator;
    public System.Collections.Generic.List<PowerTools.SpriteAnimNodeSync> NodeSyncs;
    public OverlayKillAnimation[] KillAnims;
    public UnityEngine.AnimationClip RunAnim;
    public UnityEngine.AnimationClip IdleAnim;
    public UnityEngine.AnimationClip GhostIdleAnim;
    public UnityEngine.AnimationClip EnterVentAnim;
    public UnityEngine.AnimationClip ExitVentAnim;
    public UnityEngine.AnimationClip SpawnAnim;
    public UnityEngine.AnimationClip SpawnGlowAnim;
    public UnityEngine.AnimationClip ClimbUpAnim;
    public UnityEngine.AnimationClip ClimbDownAnim;
    public UnityEngine.AnimationClip GhostGuardianAngelAnim;
    public float RunAnimTime;
    public float ShapeshiftScale;
    public UnityEngine.Vector3 defaultPlayerScale;
}
