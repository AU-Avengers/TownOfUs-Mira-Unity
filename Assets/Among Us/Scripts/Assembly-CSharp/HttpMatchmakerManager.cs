public class HttpMatchmakerManager : DestroyableSingleton
{
    public Logger logger;
    public MatchmakerToken token;
    public string base64Token;
    public class MatchmakerError : System.Object
    {
        public DisconnectReasons Reason;
        public SanctionReasons SanctionReason;
        public System.DateTimeOffset EndsAt;
}
}
