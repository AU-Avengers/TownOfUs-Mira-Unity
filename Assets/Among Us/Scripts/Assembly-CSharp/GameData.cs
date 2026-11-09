public class GameData : InnerNet.InnerNetObject, IDisconnectHandler
{
    public int TotalTasks;
    public int CompletedTasks;
    public RoleBehaviour DefaultRole;
    public class PlayerInfo : System.Object
    {
        public System.Byte PlayerId;
        public string FriendCode;
        public string Puid;
        public AmongUs.GameOptions.RoleTypes RoleType;
        public System.Nullable<AmongUs.GameOptions.RoleTypes> RoleWhenAlive;
        public System.UInt32 PlayerLevel;
        public bool Disconnected;
        public RoleBehaviour Role;
        public bool IsDead;
}
    public class PlayerOutfit : System.Object
    {
        public bool dontCensorName;
        public int ColorId;
        public string HatId;
        public string PetId;
        public string SkinId;
        public string VisorId;
        public string NamePlateId;
        public System.Action<System.String> nameCallback;
}
}
