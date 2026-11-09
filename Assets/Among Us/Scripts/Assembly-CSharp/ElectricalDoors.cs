public class ElectricalDoors : UnityEngine.MonoBehaviour, ISystemType
{
    public StaticDoor[] Doors;
    public ElectricalDoors.DoorSet[] Rooms;
    public ElectricalDoors.DoorSet LeftExits;
    [System.Serializable]
    public class DoorSet : System.Object
    {
        public string Name;
        public StaticDoor[] Doors;
}
}
