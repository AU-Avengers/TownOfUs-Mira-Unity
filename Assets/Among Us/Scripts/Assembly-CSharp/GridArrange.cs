public class GridArrange : UnityEngine.MonoBehaviour
{
    public UnityEngine.Vector2 CellSize;
    public GridArrange.StartAlign Alignment;
    public int MaxColumns;
    public enum StartAlign : int
    {
        Left = 0,
        Right = 1,
}
}
