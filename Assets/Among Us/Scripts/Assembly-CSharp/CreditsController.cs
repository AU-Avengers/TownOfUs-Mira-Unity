public class CreditsController : UnityEngine.MonoBehaviour
{
    public System.Action OnFinish;
    public UnityEngine.TextAsset CSVCredits;
    public int NumberOfContentColumns;
    public UnityEngine.GameObject creditPanelPrefab;
    public UnityEngine.GameObject creditMainPanel;
    public float creditScrollSpeed;
    public float initialDelay;
    public float startPos;
    public float remainingDelay;
    public UnityEngine.RectTransform creditsRect;
    public bool paused;
    public enum CreditType : int
    {
        TEXT = 0,
        IMAGE = 1,
}
}
