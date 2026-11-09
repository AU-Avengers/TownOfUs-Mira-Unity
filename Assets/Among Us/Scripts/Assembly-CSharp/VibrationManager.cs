public class VibrationManager : DestroyableSingleton
{
    public UnityEngine.Vector2 singleFrameVibration;
    public bool hasFrameVibration;
    public bool zeroNextFrame;
    public int numVibrationsActive;
    public UnityEngine.Vector2 currentVibration;
    public UnityEngine.Camera cam;
    public VibrationManager.WorldVibration tempSingleFrameWorldVibration;
    public VibrationManager.WorldVibration tempAmbientSoundVibration;
    public bool shouldVibrate;
    public class WorldVibration : System.Object
    {
        public float intensity;
        public UnityEngine.Vector2 location;
        public float radius;
        public float t;
        public float duration;
        public VibrationManager.VibrationFalloff falloff;
        public UnityEngine.AudioClip clip;
        public bool loopClip;
        public string name;
}
    public enum VibrationFalloff : int
    {
        None = 0,
        Linear = 1,
        InverseLinear = 2,
}
}
