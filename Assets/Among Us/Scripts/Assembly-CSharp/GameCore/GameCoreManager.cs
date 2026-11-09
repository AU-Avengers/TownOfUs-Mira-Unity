namespace GameCore
{
    public class GameCoreManager : UnityEngine.MonoBehaviour
    {
        public GameCore.LocalizationProvider LocalizationProvider;
        public System.Action OnSuspend;
        public System.Action<System.Double> OnResume;
        public System.Action<System.Boolean> OnResourceChange;
        public System.Threading.Thread dispatchJob;
        public bool stopExecution;
    }
}
