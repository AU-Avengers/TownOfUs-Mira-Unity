public class AirshipGarbageGame : Minigame
{
    public GarbageCanBehaviour[] GarbagePrefabs;
    public UnityEngine.Sprite RelaxeHandle;
    public UnityEngine.Sprite PulledHandle;
    public GarbageCanBehaviour can;
    public UnityEngine.AudioClip grabSound;
    public Controller controller;
    public UnityEngine.Transform handCursorObject;
    public UnityEngine.GameObject waitingHands;
    public UnityEngine.GameObject grabbedHands;
    public UnityEngine.SpriteRenderer[] handSprites;
    public bool prevHadLeftInput;
}
