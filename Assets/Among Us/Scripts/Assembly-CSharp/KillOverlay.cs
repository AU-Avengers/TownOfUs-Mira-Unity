public class KillOverlay : UnityEngine.MonoBehaviour
{
    public UnityEngine.SpriteRenderer background;
    public UnityEngine.GameObject flameParent;
    public OverlayKillAnimation[] KillAnims;
    public OverlayKillAnimation[] HorseWrangleAnims;
    public OverlayKillAnimation[] CustomKillAnimations;
    public UnityEngine.Coroutine showAll;
    public UnityEngine.Coroutine showOne;
}
