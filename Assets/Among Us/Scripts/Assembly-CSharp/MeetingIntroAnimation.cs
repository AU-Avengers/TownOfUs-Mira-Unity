public class MeetingIntroAnimation : UnityEngine.MonoBehaviour
{
    public UnityEngine.Transform VoteButtonParent;
    public UnityEngine.Transform OverlayParent;
    public UnityEngine.Transform DeadParent;
    public UnityEngine.GameObject ProtectedRecently;
    public TMPro.TextMeshPro DeadBodiesText;
    public UnityEngine.SpriteRenderer BloodSplat;
    public UnityEngine.Vector3 VoteButtonParentPos;
    public UnityEngine.Vector3 ReporterPos;
    public UnityEngine.SpriteRenderer background;
    public UnityEngine.AnimationCurve SlamCurve;
    public PlayerVoteArea VoteAreaPrefab;
    public UnityEngine.AudioClip PlayerDeadSound;
    public UnityEngine.AudioClip ProtectedRecentlySound;
    public UnityEngine.SpriteRenderer[] OutsideMasks;
}
