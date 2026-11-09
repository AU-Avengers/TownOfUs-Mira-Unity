public class WaterStage : Minigame
{
    public float RefuelDuration;
    public UnityEngine.SpriteRenderer waterButton;
    public UnityEngine.Sprite buttonDownSprite;
    public UnityEngine.Sprite buttonUpSprite;
    public VerticalGauge srcGauge;
    public VerticalGauge destGauge;
    public UnityEngine.AudioClip RefuelSound;
    public float timer;
    public bool isDown;
    public bool complete;
}
