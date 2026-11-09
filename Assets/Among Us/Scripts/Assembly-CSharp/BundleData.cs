public class BundleData : UnityEngine.ScriptableObject
{
    public BundleSizes BundleSize;
    public string productId;
    public int beanCost;
    public int starCost;
    public CosmeticData[] cosmetics;
    public UnityEngine.Sprite StoreImage;
    public bool NotInStore;
    public bool Free;
    public bool paidOnMobile;
}
