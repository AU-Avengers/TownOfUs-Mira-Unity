public class ResolutionSlider : UnityEngine.MonoBehaviour
{
    public int targetIdx;
    public UnityEngine.Resolution targetResolution;
    public bool targetFullscreen;
    public UnityEngine.Resolution[] allResolutions;
    public SlideBar slider;
    public ToggleButtonBehaviour Fullscreen;
    public ToggleButtonBehaviour VSync;
    public TMPro.TextMeshPro Display;
    public ToggleButtonBehaviour Screenshake;
}
