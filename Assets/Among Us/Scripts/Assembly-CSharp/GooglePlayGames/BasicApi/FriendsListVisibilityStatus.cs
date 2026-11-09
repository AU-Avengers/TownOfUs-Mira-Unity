namespace GooglePlayGames.BasicApi
{
    public enum FriendsListVisibilityStatus : int
    {
        Unknown = 0,
        Visible = 1,
        ResolutionRequired = 2,
        Unavailable = 3,
        NetworkError = -4,
        NotAuthorized = -5,
    }
}
