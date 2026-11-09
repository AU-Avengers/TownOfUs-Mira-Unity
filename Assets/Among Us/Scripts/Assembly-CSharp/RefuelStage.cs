public class RefuelStage : Minigame
{
    public float RefuelDuration;
    public UnityEngine.Color darkRed;
    public UnityEngine.Color red;
    public UnityEngine.Color green;
    public UnityEngine.SpriteRenderer redLight;
    public UnityEngine.SpriteRenderer greenLight;
    public VerticalGauge srcGauge;
    public VerticalGauge destGauge;
    public UnityEngine.AudioClip RefuelSound;
    public float timer;
    public bool isDown;
    public bool complete;
    public bool usingController;
}
