public class PassiveButton : PassiveUiElement
{
    public UnityEngine.UI.Button.ButtonClickedEvent OnClick;
    public UnityEngine.AudioClip ClickSound;
    public UnityEngine.AudioClip HoverSound;
    public bool OnUp;
    public bool OnDown;
    public bool OnRepeat;
    public float RepeatDuration;
    public UnityEngine.SpriteRenderer HeldButtonSprite;
    public ActionButton TargetActionButton;
    public bool HoldToUse;
    public bool beingHeldDown;
    public float repeatTimer;
    public float totalHeldTime;
    public bool checkedClickEvent;
    public UnityEngine.GameObject activeSprites;
    public UnityEngine.GameObject inactiveSprites;
    public UnityEngine.GameObject disabledSprites;
    public TMPro.TextMeshPro buttonText;
    public UnityEngine.Color activeTextColor;
    public UnityEngine.Color inactiveTextColor;
    public UnityEngine.Color disabledTextColor;
}
