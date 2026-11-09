public class CustomNetworkTransform : InnerNet.InnerNetObject
{
    public PlayerControl myPlayer;
    public UnityEngine.Rigidbody2D body;
    public float rubberbandModifier;
    public float idealSpeed;
    public bool isPaused;
    public System.UInt16 lastSequenceId;
    public UnityEngine.Vector2 lastPosition;
    public UnityEngine.Vector2 lastPosSent;
    public System.Nullable<UnityEngine.Vector2> tempSnapPosition;
    public InnerNet.GizmoHelpers.ITransformGhost debugPopPositions;
    public InnerNet.GizmoHelpers.ITransformGhost debugTargetPositions;
    public InnerNet.GizmoHelpers.ITransformGhost debugTruePositions;
    public InnerNet.GizmoHelpers.INetTransformLogger debugNetLogger;
}
