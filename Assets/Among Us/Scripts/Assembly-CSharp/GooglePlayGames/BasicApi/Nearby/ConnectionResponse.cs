namespace GooglePlayGames.BasicApi.Nearby
{
    public struct ConnectionResponse
    {
        public enum Status : int
        {
            Accepted = 0,
            Rejected = 1,
            ErrorInternal = 2,
            ErrorNetworkNotConnected = 3,
            ErrorEndpointNotConnected = 4,
            ErrorAlreadyConnected = 5,
}
    }
}
