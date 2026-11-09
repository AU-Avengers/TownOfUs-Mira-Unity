public class SlideBar : PassiveUiElement
{
    public TMPro.TextMeshPro Title;
    public UnityEngine.SpriteRenderer Bar;
    public UnityEngine.SpriteRenderer Dot;
    public FloatRange Range;
    public bool Vertical;
    public float Value;
    public UnityEngine.Events.UnityEvent OnValueChange;
    public float sliderSegmentIncrement;
}
