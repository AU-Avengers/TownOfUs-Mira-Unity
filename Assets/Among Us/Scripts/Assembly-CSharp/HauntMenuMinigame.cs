public class HauntMenuMinigame : Minigame
{
    public TMPro.TextMeshPro NameText;
    public TMPro.TextMeshPro FilterText;
    public TMPro.TextMeshPro HauntingText;
    public HauntMenuMinigame.HauntFilters filterMode;
    public PassiveButton[] FilterButtons;
    public PassiveButton[] Arrows;
    public PlayerControl HauntTarget;
    public UnityEngine.Vector2 Offset;
    public enum HauntFilters : int
    {
        None = 0,
        Impostor = 1,
        Crewmate = 2,
        Ghost = 3,
}
}
