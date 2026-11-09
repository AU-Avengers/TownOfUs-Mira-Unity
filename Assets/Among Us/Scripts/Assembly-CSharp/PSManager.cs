public class PSManager : DestroyableSingleton
{
    public UnityEngine.Texture2D ps4SessionImage;
    public System.Byte[] ps4SessionImageAsPNG;
    public JoinSessionSource joinSessionSource;
    public bool gameplayStarted;
    public bool keepBlockerActive;
}
