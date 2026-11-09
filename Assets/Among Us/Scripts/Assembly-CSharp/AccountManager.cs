public class AccountManager : DestroyableSingleton
{
    public AccountTab accountTab;
    public UnityEngine.GameObject accountWindow;
    public PermissionsRequest enterGuardianEmailWindow;
    public UpdateGuardianEmail updateGuardianEmailWindow;
    public InfoTextBox guardianEmailConfirmWindow;
    public InfoTextBox genericInfoDisplayBox;
    public AgeGateScreen enterDateOfBirthScreen;
    public UnityEngine.GameObject waitingText;
    public UnityEngine.GameObject postLoadWaiting;
    public UnityEngine.GameObject privacyPolicyBg;
    public SignInScreen signInScreen;
    public PrivacyPolicyScreen PrivacyPolicy;
    public IChatModeDisplay chatModeMenuScreen;
    public System.Action OnLoggedInStatusChange;
    public EOSManager.AccountLoginStatus prevLoggedInStatus;
    public TMPro.TextMeshPro accountDeletionText;
    public bool isAccountWaitingForDeletion;
}
