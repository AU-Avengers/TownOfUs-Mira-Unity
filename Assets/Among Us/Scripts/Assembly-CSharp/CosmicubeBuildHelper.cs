public class CosmicubeBuildHelper : UnityEngine.MonoBehaviour
{
    public CosmicubeCell cell;
    public CosmicubeBuildHelper.CubeSide cubeSide;
    public UnityEngine.GameObject connector;
    public bool childOwned;
    public bool animating;
    public enum CubeSide : int
    {
        East = 0,
        West = 1,
        North = 2,
        South = 3,
}
}
