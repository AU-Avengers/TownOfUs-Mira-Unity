public class ProgressionScreen : UnityEngine.MonoBehaviour
{
    public PoolablePlayer Player;
    public UnityEngine.AudioClip XpSound;
    public UnityEngine.AudioClip LevelUpSound;
    public ProgressBar XpBar;
    public TMPro.TextMeshPro XpEarnedNowText;
    public UnityEngine.AnimationCurve XpEarnedNowCurve;
    public TMPro.TextMeshPro LevelText;
    public UnityEngine.Transform LevelCircle;
    public TMPro.TextMeshPro FutureLevelText;
    public CurrencyEarned PodsEarned;
    public CurrencyEarned BeansEarned;
}
