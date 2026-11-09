public class LeafMinigame : Minigame
{
    public LeafBehaviour LeafPrefab;
    public Vector2Range ValidArea;
    public PowerTools.SpriteAnim[] Arrows;
    public UnityEngine.AnimationClip[] Inactive;
    public UnityEngine.AnimationClip[] Active;
    public UnityEngine.AnimationClip[] Complete;
    public UnityEngine.Collider2D[] Leaves;
    public UnityEngine.AudioClip[] LeaveSounds;
    public UnityEngine.AudioClip[] SuckSounds;
    public Controller myController;
    public UnityEngine.Transform interactionCursor;
    public UnityEngine.Transform interactionCursorCenterDot;
    public UnityEngine.Collider2D[] overlapResults;
    public bool prevHadOverlaps;
    public bool prevRightStickInput;
}
