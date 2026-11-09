public class Scroller : PassiveUiElement
{
    public UnityEngine.Transform Inner;
    public bool allowY;
    public bool showY;
    public FloatRange ContentYBounds;
    public FloatRange ScrollbarYBounds;
    public Scrollbar ScrollbarY;
    public bool allowX;
    public bool showX;
    public FloatRange ContentXBounds;
    public FloatRange ScrollbarXBounds;
    public Scrollbar ScrollbarX;
    public float DragScrollSpeed;
    public float ScrollWheelSpeed;
    public bool MouseMustBeOverToScroll;
    public UnityEngine.Vector2 velocity;
    public bool active;
    public bool mouseOver;
}
