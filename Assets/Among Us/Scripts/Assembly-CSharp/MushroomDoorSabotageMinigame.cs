public class MushroomDoorSabotageMinigame : Minigame, IDoorMinigame
{
    public FloatRange mushroomInvisibleSeconds;
    public FloatRange mushroomVisibleSeconds;
    public TMPro.TextMeshPro counterText;
    public UnityEngine.Transform[] spawnPoints;
    public MushroomDoorSabotageMinigameMushroom[] mushroomVariants;
    public OpenableDoor myDoor;
    public int mushroomWhackCount;
}
