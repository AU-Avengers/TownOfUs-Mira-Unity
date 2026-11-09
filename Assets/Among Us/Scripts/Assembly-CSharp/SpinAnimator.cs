public class SpinAnimator : UnityEngine.MonoBehaviour
{
    public float Speed;
    public UnityEngine.GameObject inputGlyph;
    public SpinAnimator.States curState;
    public enum States : int
    {
        Visible = 0,
        Invisible = 1,
        Spinning = 2,
        Pulsing = 3,
}
}
