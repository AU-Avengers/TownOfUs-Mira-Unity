public class ChatController : UnityEngine.MonoBehaviour
{
    public UnityEngine.GameObject chatButton;
    public AspectPosition chatButtonAspectPosition;
    public BanMenu banButton;
    public UnityEngine.GameObject openKeyboardButton;
    public PassiveButton quickChatButton;
    public UnityEngine.GameObject chatScreen;
    public ObjectPoolBehavior chatBubblePool;
    public Scroller scroller;
    public UnityEngine.SpriteRenderer backgroundImage;
    public UnityEngine.SpriteRenderer chatNotifyDot;
    public TMPro.TextMeshPro sendRateMessageText;
    public AspectPosition aspectPosition;
    public FreeChatInputField freeChatField;
    public AmongUs.QuickChat.QuickChatMenu quickChatMenu;
    public AmongUs.QuickChat.QuickChatPreviewField quickChatField;
    public UnityEngine.AudioClip messageSound;
    public UnityEngine.AudioClip warningSound;
    public UnityEngine.AnimationCurve chatAnimationIn;
    public UnityEngine.AnimationCurve chatAnimationOut;
    public UiElement backButton;
    public UiElement defaultButtonSelected;
    public ChatControllerState state;
    public UnityEngine.Vector3 targetChatPosition;
    public float timeSinceLastMessage;
    public UnityEngine.Coroutine notificationRoutine;
    public SpecialInputHandler specialInputHandler;
    public float targetScale;
}
