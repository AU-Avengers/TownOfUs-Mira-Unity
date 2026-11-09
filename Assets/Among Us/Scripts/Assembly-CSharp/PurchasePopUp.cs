public class PurchasePopUp : UnityEngine.MonoBehaviour
{
    public UnityEngine.GameObject waitingText;
    public TMPro.TextMeshPro titleText;
    public TMPro.TextMeshPro infoText;
    public UnityEngine.GameObject closeButton;
    public UnityEngine.GameObject controllerFocusHolder;
    public enum PurchasePopUpMode : int
    {
        PurchaseItem = 0,
        CheckingPurchases = 1,
}
}
