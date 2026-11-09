public class VirtualJoystick : UnityEngine.MonoBehaviour, IVirtualJoystick
{
    public float InnerRadius;
    public float OuterRadius;
    public UnityEngine.CircleCollider2D Outer;
    public UnityEngine.SpriteRenderer Inner;
    public UnityEngine.SpriteRenderer[] AllSprites;
    public bool IsDragged;
    public bool IsRightJoystick;
    public VirtualJoystickController myController;
}
