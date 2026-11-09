public class CosmicubeData : UnityEngine.ScriptableObject
{
    public UnityEngine.AddressableAssets.AssetReference StoreImageRef;
    public UnityEngine.AddressableAssets.AssetReference CosmicubePrefabRef;
    public UnityEngine.AddressableAssets.AssetReference podIconRef;
    public string DateCreated;
    public int starCost;
    public int beanCost;
    public int Order;
    public bool Free;
    public bool NotInStore;
    public FloatRange XRange;
    public FloatRange YRange;
    public string podId;
}
