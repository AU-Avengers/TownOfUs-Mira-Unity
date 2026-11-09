public class PlayerPhysics : InnerNet.InnerNetObject
{
    public System.Byte lastClimbLadderSid;
    public UnityEngine.AudioClip ImpostorDiscoveredSound;
    public PlayerAnimations Animations;
    public SpecialInputHandler inputHandler;
    public float Speed;
    public float GhostSpeed;
    public Logger logger;
    public UnityEngine.Rigidbody2D body;
    public PlayerControl myPlayer;
    public PlayerBodyTypes bodyType;
    public UnityEngine.Coroutine petCoroutine;
}
