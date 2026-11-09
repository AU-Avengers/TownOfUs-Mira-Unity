public class DualshockLightManager : DestroyableSingleton
{
    public UnityEngine.Color baseColor;
    public UnityEngine.Color oldColor;
    public class LightOverlayHandle : System.Object
    {
        public UnityEngine.Color color;
        public float intensity;
}
}
