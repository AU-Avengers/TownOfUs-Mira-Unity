namespace AmongUsServer
{
    public enum ExtensionFailureReasons : System.Byte
    {
        Invalid = 0,
        WrongGameState = 1,
        OutOfExtensionThreshold = 2,
        NoExtensionAvailable = 3,
        WrongExtensionId = 4,
        ExtensionAlreadyRequested = 5,
    }
}
