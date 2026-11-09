public class HowToPlayScene : UnityEngine.MonoBehaviour
{
    public UnityEngine.GameObject startPage;
    public UnityEngine.GameObject arrows;
    public UnityEngine.SpriteRenderer leftButton;
    public UnityEngine.SpriteRenderer rightButton;
    public UiElement closeButton;
    public UnityEngine.Transform dotParent;
    public UnityEngine.Transform dotTemplate;
    public AbstractHowToPlayScenePage[] classicScenes;
    public AbstractHowToPlayScenePage[] hideAndSeekScenes;
    public ConditionalHowToPlayScenePage pcMove;
    public AbstractHowToPlayScenePage[] rolesScenes;
    public UiElement defaultButtonSelected;
    public int sceneIndex;
    public UnityEngine.Transform[] dots;
    public HowToPlayScene.HowToPlayCategory category;
    public enum HowToPlayCategory : int
    {
        None = 0,
        GameMode_Classic = 100,
        GameMode_HideAndSeek = 101,
        Roles = 200,
}
}
