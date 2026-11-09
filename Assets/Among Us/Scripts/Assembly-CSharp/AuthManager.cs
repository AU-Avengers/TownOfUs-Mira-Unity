public class AuthManager : DestroyableSingleton
{
    public Hazel.Dtls.DtlsUnityConnection connection;
    public System.Nullable<System.UInt32> LastNonceReceived;
}
