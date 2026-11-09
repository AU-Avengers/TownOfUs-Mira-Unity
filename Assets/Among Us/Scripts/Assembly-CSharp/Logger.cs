public class Logger : System.Object
{
    public enum Category : int
    {
        None = 0,
        Network = 1,
        Server = 2,
        UI = 3,
        Gameplay = 4,
        Assets = 5,
        DataManager = 6,
        Addressables = 7,
}
    public enum Level : int
    {
        None = 0,
        Error = 1,
        Warning = 2,
        Info = 3,
        Debug = 4,
}
}
