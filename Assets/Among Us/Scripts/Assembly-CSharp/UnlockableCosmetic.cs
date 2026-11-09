public class UnlockableCosmetic : UnityEngine.ScriptableObject
{
    public UnlockableCosmetic.UnlockableQuality quality;
    public CosmeticData unlockableCosmetic;
    public int cost;
    public enum UnlockableQuality : int
    {
        Nameplate = 1,
        Hat = 2,
        Visor = 3,
        Skin = 4,
        Pet = 5,
        Kill = 6,
}
}
