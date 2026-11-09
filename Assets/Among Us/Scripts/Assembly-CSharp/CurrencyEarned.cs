public class CurrencyEarned : UnityEngine.MonoBehaviour
{
    public UnityEngine.Sprite BeansIcon;
    public UnityEngine.SpriteRenderer Icon;
    public TMPro.TextMeshPro AmountEarnedNowText;
    public TMPro.TextMeshPro WalletCountText;
    public TMPro.TextMeshPro NameText;
    public UnityEngine.GameObject MultiplierContainer;
    public TMPro.TextMeshPro[] MultiplierTexts;
    public PowerTools.SpriteAnim Animator;
    public UnityEngine.AnimationClip ShowAmountAnimation;
    public UnityEngine.AnimationClip EnterWalletAnimation;
    public UnityEngine.AudioClip ShowAmountSound;
    public UnityEngine.AudioClip EnterWalletSound;
    public UnityEngine.AudioClip MultiplierLoopSound;
    public UnityEngine.AudioClip MultiplierEndSound;
    public ProgressionManager.CurrencyGrantResult grantResult;
}
