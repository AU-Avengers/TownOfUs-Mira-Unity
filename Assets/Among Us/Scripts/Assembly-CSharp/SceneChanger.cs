public class SceneChanger : UnityEngine.MonoBehaviour
{
    public string TargetScene;
    public bool disallowBasedOnSwitchParentalControls;
    public bool disallowBasedOnAssetPackDownloads;
    public UnityEngine.GameObject ConnectIcon;
    public UnityEngine.UI.Button.ButtonClickedEvent BeforeSceneChange;
    public UnityEngine.AsyncOperation loadOp;
}
