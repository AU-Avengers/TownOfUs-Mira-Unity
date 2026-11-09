namespace GameCore
{
    public class UserManager : System.Object
    {
        public enum UserOpResult : int
        {
            Success = 0,
            NoDefaultUser = 1,
            ResolveUserIssueRequired = 2,
            UnclearedVetoes = 3,
            UnknownError = 4,
}
        public class UserData : System.Object
        {
}
        public enum State : int
        {
            Initializing = 0,
            GetContext = 1,
            WaitForAddingUser = 2,
            GetBasicInfo = 3,
            InitializeNetwork = 4,
            GrabAchievements = 5,
            UserDisplayImage = 6,
            ReturnMuteList = 7,
            ReturnAvoidList = 8,
            UserPermissionsCheck = 9,
            WaitForNextTask = 10,
            Error = 11,
            Idle = 12,
            End = 13,
}
    }
}
