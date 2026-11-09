public class HeliSabotageSystem : UnityEngine.MonoBehaviour, ISystemType, ICriticalSabotage, IActivatable
{
    public UnityEngine.SpriteRenderer Helicopter;
    public UnityEngine.AnimationCurve ScaleCurve;
    public float codeResetTimer;
    public float syncTimer;
    public bool wasActive;
    public enum Tags : int
    {
        DamageBit = 128,
        ActiveBit = 64,
        DeactiveBit = 32,
        FixBit = 16,
}
}
