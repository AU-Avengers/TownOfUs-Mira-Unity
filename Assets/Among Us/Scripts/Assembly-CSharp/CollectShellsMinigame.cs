public class CollectShellsMinigame : Minigame
{
    public CollectableShell[] shellPrefabs;
    public UnityEngine.Transform[] spawnPositions;
    public IntRange numShellsRange;
    public UnityEngine.GameObject controllerCursor;
    public UnityEngine.GameObject handWipeObject;
    public UnityEngine.AudioClip[] dustSounds;
    public Controller controller;
    public UnityEngine.Vector2 prevMousePos;
    public UnityEngine.Vector2 prevControllerStickPos;
    public float wipeDistance;
    public float maxProgress;
    public float controllerDifficulty;
    public float mouseDifficulty;
}
