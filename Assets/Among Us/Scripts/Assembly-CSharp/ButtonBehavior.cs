public class ButtonBehavior : UiElement
{
    public bool OnUp;
    public bool OnDown;
    public bool Repeat;
    public UnityEngine.UI.Button.ButtonClickedEvent OnClick;
    public Controller myController;
    public UnityEngine.Collider2D[] colliders;
    public float downTime;
    public UnityEngine.SpriteRenderer spriteRenderer;
    public bool checkedClickEvent;
}
