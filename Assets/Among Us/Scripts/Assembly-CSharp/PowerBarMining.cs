public class PowerBarMining : UnityEngine.MonoBehaviour
{
    public UnityEngine.SpriteRenderer spriteRenderer;
    public PassiveButton passiveButton;
    public float barSpeed;
    public float currentPercentage;
    public bool updatePowerMeter;
    public System.Action<System.Single,UnityEngine.Vector3> hitRock;
    public System.Action<System.Single> onPitch;
    public UnityEngine.Vector3 clickPos;
    public Controller controller;
}
