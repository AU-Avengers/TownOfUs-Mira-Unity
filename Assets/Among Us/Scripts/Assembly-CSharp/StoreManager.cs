public class StoreManager : DestroyableSingleton
{
    public UnityEngine.Purchasing.Product[] allProducts;
    public bool FinishedInitializationFlow;
    public Logger logger;
    public UnityEngine.Purchasing.IStoreController controller;
    public UnityEngine.Purchasing.IExtensionProvider extensions;
    public bool initialized;
}
