namespace Twitch
{
    public class TwitchManager : DestroyableSingleton
    {
        public string verify;
        public GenericPopup TwitchPopup;
        public Twitch.TwitchManager.UpdateState running;
        public enum UpdateState : int
        {
            NotStarted = 0,
            Started = 1,
            Success = 2,
            Failure = 3,
}
    }
}
