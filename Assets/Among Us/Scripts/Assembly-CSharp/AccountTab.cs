public class AccountTab : UnityEngine.MonoBehaviour
{
    public TMPro.TextMeshPro userName;
    public TMPro.TextMeshPro friendCode;
    public TMPro.TextMeshPro friendCodeTitle;
    public PoolablePlayer playerImage;
    public UnityEngine.GameObject friendCodeObject;
    public UnityEngine.SpriteRenderer FriendCodeHiddenIcon;
    public UnityEngine.GameObject offlineMode;
    public UnityEngine.GameObject guestMode;
    public FullAccount loggedInMode;
    public UnityEngine.GameObject waitingForGuardian;
    public TMPro.TextMeshPro guardianEmailText;
    public EditName editNameScreen;
    public UnityEngine.GameObject idCard;
    public UnityEngine.GameObject resendEmailButton;
    public TMPro.TextMeshPro levelText;
    public ProgressBar xpProgressBar;
    public TMPro.TextMeshPro veryBadErrorText;
    public UnityEngine.Collider2D clickToCloseCollider;
    public TMPro.TextMeshPro accountIDDisplayText;
    public UnityEngine.GameObject showAccountIDButton;
    public UnityEngine.SpriteRenderer SpaceBean;
    public UnityEngine.SpriteRenderer SpaceHorse;
    public InfoTextBox InfoTextBoxDisplay;
    public SignInStatusComponent signInStatusComponent;
    public bool showAccountID;
    public string friendCodeHiddenText;
    public UiElement BackButton;
}
