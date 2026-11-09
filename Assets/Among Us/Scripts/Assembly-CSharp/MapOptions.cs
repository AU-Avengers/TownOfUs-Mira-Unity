public class MapOptions : System.Object
{
    public MapOptions.Modes Mode;
    public bool AllowMovementWhileMapOpen;
    public bool ShowLivePlayerPosition;
    public bool IncludeDeadBodies;
    public enum Modes : int
    {
        None = 0,
        Normal = 1,
        CountOverlay = 2,
        Sabotage = 3,
}
}
