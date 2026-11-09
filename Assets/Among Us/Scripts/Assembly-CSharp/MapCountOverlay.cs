public class MapCountOverlay : UnityEngine.MonoBehaviour
{
    public AlphaPulse BackgroundColor;
    public TMPro.TextMeshPro SabotageText;
    public CounterArea[] CountAreas;
    public UnityEngine.Collider2D[] buffer;
    public UnityEngine.ContactFilter2D filter;
    public float timer;
    public bool isSab;
    public bool showLivePlayerPosition;
    public bool includeDeadBodies;
}
