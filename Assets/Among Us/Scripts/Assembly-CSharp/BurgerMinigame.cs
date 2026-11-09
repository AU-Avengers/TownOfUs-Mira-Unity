public class BurgerMinigame : Minigame
{
    public BurgerTopping Plate;
    public BurgerTopping[] Toppings;
    public UnityEngine.Sprite[] PaperToppings;
    public UnityEngine.SpriteRenderer[] PaperSlots;
    public BurgerToppingTypes[] ExpectedToppings;
    public Controller controller;
    public UnityEngine.Transform Paper;
    public bool PaperClosed;
    public UnityEngine.SpriteRenderer Shadow;
    public UnityEngine.Transform stickCursor;
    public UnityEngine.SpriteRenderer handSprite;
    public UnityEngine.BoxCollider2D stickSelectionCenterPoint;
    public UnityEngine.Vector3 selectionCenterStart;
    public BurgerTopping stickSelectedTopping;
    public bool grabbedTopping;
    public UnityEngine.Vector3 internalCursorPos;
    public float cursorLerpSpeed;
    public float cursorHoverLerpSpeed;
    public float stackHeight;
}
