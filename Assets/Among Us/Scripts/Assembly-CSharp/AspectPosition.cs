public class AspectPosition : UnityEngine.MonoBehaviour
{
    public UnityEngine.Camera parentCam;
    public bool updateAlways;
    public UnityEngine.Vector2 anchorPoint;
    public UnityEngine.Vector3 DistanceFromEdge;
    public AspectPosition.EdgeAlignments Alignment;
    public enum EdgeAlignments : int
    {
        RightBottom = 6,
        LeftBottom = 5,
        RightTop = 10,
        Left = 1,
        Right = 2,
        Top = 8,
        Bottom = 4,
        LeftTop = 9,
        Center = 16,
}
}
