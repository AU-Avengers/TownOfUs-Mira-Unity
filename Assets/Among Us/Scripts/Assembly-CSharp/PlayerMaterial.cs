public class PlayerMaterial : System.Object
{
    public struct Properties
    {
        public bool IsLocalPlayer;
        public PlayerMaterial.MaskType MaskType;
        public int MaskLayer;
        public int ColorId;
}
    public enum MaskType : int
    {
        None = 0,
        SimpleUI = 1,
        ComplexUI = 2,
        Exile = 3,
        ScrollingUI = 4,
}
}
