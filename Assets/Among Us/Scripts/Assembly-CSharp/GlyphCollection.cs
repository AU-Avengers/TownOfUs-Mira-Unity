public class GlyphCollection : UnityEngine.ScriptableObject
{
    public string controllerType;
    public enum ErrorCode : int
    {
        None = 0,
        NoController = 1,
        NoGlyphFound = 2,
        NoElementsBoundToAction = 3,
}
}
