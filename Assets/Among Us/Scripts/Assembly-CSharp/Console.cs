public class Console : UnityEngine.MonoBehaviour, IUsable
{
    public float usableDistance;
    public int ConsoleId;
    public bool onlyFromBelow;
    public bool onlySameRoom;
    public bool checkWalls;
    public bool GhostsIgnored;
    public bool AllowImpostor;
    public SystemTypes Room;
    public TaskTypes[] TaskTypes;
    public TaskSet[] ValidTasks;
    public UnityEngine.SpriteRenderer Image;
    public void Use() { }
}
