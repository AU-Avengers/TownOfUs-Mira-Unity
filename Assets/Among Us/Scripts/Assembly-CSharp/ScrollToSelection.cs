public class ScrollToSelection : UnityEngine.MonoBehaviour
{
    public float scrollOffset;
    public Scroller scrollRect;
    public bool manuallyScrolling;
    public UIScrollbarHelper[] childElements;
    public UnityEngine.Vector2 wantedValue;
    public UnityEngine.GameObject lastSelectedObject;
    public bool cursorEnabled;
    public bool killScroll;
    public bool onePage;
}
