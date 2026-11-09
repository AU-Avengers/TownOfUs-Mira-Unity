public class TowelMinigame : Minigame
{
    public FloatRange towelRange;
    public UnityEngine.SpriteRenderer BasketGauge;
    public UnityEngine.Collider2D BasketHitbox;
    public UnityEngine.Collider2D[] Towels;
    public Controller controller;
    public int towelsDone;
    public UnityEngine.AudioClip TowelGrab;
    public UnityEngine.AudioClip TowelLand;
    public UnityEngine.Transform interactionCursor;
    public UnityEngine.SpriteRenderer openHand;
    public UnityEngine.SpriteRenderer holdingHand;
    public Vector2Range ValidArea;
    public float stickMoveSpeed;
    public float stickHeldSpeed;
    public float towelDragSpeed;
    public UnityEngine.Collider2D[] overlapResults;
    public bool isHolding;
    public UnityEngine.GameObject heldTowel;
}
