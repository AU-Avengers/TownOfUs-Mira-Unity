public class FindAGameManager : DestroyableSingleton, IGameListHandler
{
    public AprilFoolsModeToggleButton AprilFoolsToggle;
    public float timer;
    public ObjectPoolBehavior buttonPool;
    public SpinAnimator RefreshSpinner;
    public Scroller TargetArea;
    public TMPro.TextMeshPro TotalText;
    public float ButtonStart;
    public float ButtonHeight;
    public UiElement BackButton;
    public UiElement DefaultButtonSelected;
}
