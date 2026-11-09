public class BreakableRock : UnityEngine.MonoBehaviour
{
    public UnityEngine.SpriteRenderer spriteRenderer;
    public UnityEngine.Sprite[] rockSprites;
    public PassiveButton passiveButton;
    public UnityEngine.AnimationCurve animCurve;
    public CollectableOre myOre;
    public UnityEngine.Collider2D col;
    public System.Action<CollectableOre,UnityEngine.Vector3> powerMeterAction;
    public Controller controller;
}
