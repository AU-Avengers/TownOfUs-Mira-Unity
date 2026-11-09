public class VendingMinigame : Minigame
{
    public TMPro.TextMeshPro NumberText;
    public UnityEngine.SpriteRenderer TargetImage;
    public string enteredCode;
    public bool animating;
    public bool done;
    public string targetCode;
    public UnityEngine.SpriteRenderer AcceptButton;
    public VendingSlot[] Slots;
    public UnityEngine.Sprite[] Drinks;
    public UnityEngine.Sprite[] DrawnDrinks;
    public UnityEngine.AudioClip Ambience;
    public UnityEngine.AudioClip Button;
    public UnityEngine.AudioClip Error;
    public UnityEngine.AudioClip SliderOpen;
    public UnityEngine.AudioClip DrinkShake;
    public UnityEngine.AudioClip DrinkLand;
    public UiElement BackButton;
    public UiElement DefaultButtonSelected;
}
