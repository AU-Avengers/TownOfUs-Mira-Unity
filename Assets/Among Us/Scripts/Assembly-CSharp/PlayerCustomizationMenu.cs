public class PlayerCustomizationMenu : UnityEngine.MonoBehaviour
{
    public UnityEngine.GameObject cosmicubeMenuTab;
    public CubesTab cubesTab;
    public TabButton[] Tabs;
    public int selectedTab;
    public bool cubeTabSelected;
    public PoolablePlayer PreviewArea;
    public UnityEngine.GameObject equipButton;
    public UnityEngine.GameObject equippedText;
    public UnityEngine.GameObject nameplateMaskArea;
    public UnityEngine.GameObject cubeArea;
    public TMPro.TextMeshPro itemName;
    public System.Action OnClose;
    public System.Action OnOpen;
    public UnityEngine.GameObject AprilFoolText;
    public UiElement BackButton;
    public UiElement DefaultButtonSelected;
    public UnityEngine.GameObject glyphL;
    public UnityEngine.GameObject glyphR;
    public Logger logger;
}
