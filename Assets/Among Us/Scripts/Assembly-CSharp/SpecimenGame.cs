public class SpecimenGame : Minigame
{
    public UnityEngine.Collider2D[] Specimens;
    public UnityEngine.Transform[] Slots;
    public Controller cont;
    public UnityEngine.AudioClip[] PlaceSounds;
    public UnityEngine.SpriteRenderer[] SpecimenSprites;
    public UnityEngine.Color highlightColor;
    public bool completed;
    public bool prevHadStick;
    public bool prevHadButton;
    public int prevSelectedSpecimen;
    public int selectedSpecimen;
}
