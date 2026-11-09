public class CollectableVegetable : UnityEngine.MonoBehaviour
{
    public float secondsToHoldBeforeCollecting;
    public UnityEngine.GameObject carrot;
    public UnityEngine.GameObject cauliflower;
    public UnityEngine.GameObject chard;
    public UnityEngine.GameObject curls;
    public CollectableVegetable neighborUp;
    public CollectableVegetable neighborDown;
    public CollectableVegetable neighborLeft;
    public CollectableVegetable neighborRight;
    public UnityEngine.GameObject vegetableContainer;
    public UnityEngine.Collider2D collider;
    public UnityEngine.GameObject selectionGlyph;
    public UnityEngine.GameObject selectionCursor;
    public UnityEngine.AudioClip pullSfx;
    public UnityEngine.AudioClip[] pickSfx;
    public CollectVegetablesMinigame.Vegetable vegetableType;
    public UnityEngine.GameObject currentVegetable;
    public Controller controller;
    public bool selected;
    public float stretchStartTime;
    public int veggieIndex;
    public bool stretching;
    public bool collected;
    public UnityEngine.Coroutine shrinkCoroutine;
}
