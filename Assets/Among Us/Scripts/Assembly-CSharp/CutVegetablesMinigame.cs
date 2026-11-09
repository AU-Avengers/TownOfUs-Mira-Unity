public class CutVegetablesMinigame : Minigame
{
    public CuttableVegetable[] cuttableVeggies;
    public UnityEngine.Transform startArea;
    public PassiveButton startAreaButton;
    public PassiveButton cuttingBoardButton;
    public UnityEngine.Transform cuttingBoard;
    public UnityEngine.Transform endArea;
    public UnityEngine.GameObject arrow;
    public UnityEngine.SpriteRenderer knife;
    public UnityEngine.Sprite cuttingKnifeSprite;
    public float knifeCutYOffset;
    public UnityEngine.AudioClip getSfx;
    public UnityEngine.AudioClip finishSfx;
    public UnityEngine.AudioClip[] cutSfx;
    public UnityEngine.GameObject selectGlyph;
    public UnityEngine.GameObject chopGlyph;
    public bool selecting;
    public bool chopping;
    public int numVeggiesCut;
}
