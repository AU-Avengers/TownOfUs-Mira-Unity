public class ControllerHeldButtonBehaviour : UnityEngine.MonoBehaviour
{
    public RewiredConstsEnum.Action Action;
    public UnityEngine.SpriteRenderer targetCooldownSprite;
    public float holdDuration;
    public ActionButton TargetActionButton;
    public ButtonBehavior buttonBehavior;
    public PassiveButton passiveButton;
    public float holdTimer;
    public bool alreadyPressed;
}
