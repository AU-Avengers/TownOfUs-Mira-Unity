public class AmongUsClient : InnerNet.InnerNetClient
{
    public string OnlineScene;
    public string MainMenuScene;
    public GameData GameDataPrefab;
    public PlayerControl PlayerPrefab;
    public int TutorialMapId;
    public float SpawnRadius;
    public DiscoveryState discoverState;
    public CrossplayPrivilegeErrorType CrossplayPrivilegeError;
    public int MAX_CLIENT_WAIT_TIME;
    public Logger logger;
    public UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> ShipLoadingAsyncHandle;
}
