public class MemoryStatsView : UnityEngine.MonoBehaviour
{
    public UnityEngine.GameObject background;
    public TMPro.TextMeshProUGUI gcMemoryText;
    public TMPro.TextMeshProUGUI systemMemoryText;
    public TMPro.TextMeshProUGUI textureMemoryText;
    public string statsText;
    public Unity.Profiling.ProfilerRecorder systemMemoryRecorder;
    public Unity.Profiling.ProfilerRecorder gcMemoryRecorder;
    public Unity.Profiling.ProfilerRecorder textureMemoryRecorder;
    public bool isVisible;
    public bool isRecording;
}
