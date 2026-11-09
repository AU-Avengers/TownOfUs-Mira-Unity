public class AnnouncementPopUp : UnityEngine.MonoBehaviour
{
    public System.Action ActionOnDisable;
    public System.Action ActionOnEnable;
    public MainMenuManager mainMenuManager;
    public UnityEngine.GameObject ConnectIcon;
    public AnnouncementPanel AnnouncementPanelPrefab;
    public TMPro.TextMeshPro Title;
    public TMPro.TextMeshPro SubTitle;
    public TMPro.TextMeshPro DateString;
    public TMPro.TextMeshPro AnnouncementBodyText;
    public UnityEngine.GameObject AnnouncementListSlider;
    public Scroller TextScroller;
    public Scroller ListScroller;
    public ManualScrollHelper ManualScrollHelper;
    public AnnouncementPanel ErrorPanel;
    public UnityEngine.GameObject ListStateHUD;
    public UnityEngine.GameObject ReadingStateHUD;
    public NewsCountButton NewsCountButton;
    public UnityEngine.Vector3 panelStartPos;
    public int newestAnnouncement;
    public AnnouncementPanel selectedPanel;
    public int selectedIndex;
    public System.Action OnDismissed;
    public Logger logger;
    public UiElement BackButton;
    public UiElement ReadingBackButton;
    public bool readingAnnouncement;
    public enum AnnounceState : int
    {
        NotStarted = 0,
        Fetching = 1,
        Failed = 2,
        Success = 3,
        Cached = 4,
}
}
