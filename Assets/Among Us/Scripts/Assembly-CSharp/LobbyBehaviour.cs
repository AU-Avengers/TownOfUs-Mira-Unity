public class LobbyBehaviour : InnerNet.InnerNetObject
{
    public UnityEngine.AudioClip SpawnSound;
    public UnityEngine.AnimationClip SpawnInClip;
    public UnityEngine.Vector2[] SpawnPositions;
    public UnityEngine.AudioClip DropShipSound;
    public SkeldShipRoom[] AllRooms;
    public Logger logger;
    public float lastFriendsCheckTime;
    public float optionsTimer;
    public int currentExtensionId;
}
