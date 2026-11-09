public class AdjustSteeringGame : Minigame
{
    public UnityEngine.Collider2D Thrust;
    public UnityEngine.Collider2D Steering;
    public UnityEngine.SpriteRenderer ThrustTarget;
    public UnityEngine.SpriteRenderer SteeringTarget;
    public Controller controller;
    public float TargetThrustY;
    public float TargetSteeringRot;
    public bool thrustLocked;
    public bool steeringLocked;
    public float startAngle;
    public UnityEngine.AudioClip HornSound;
    public bool prevHadLeftInput;
    public bool prevHadRightInput;
    public UnityEngine.Vector2 prevRightStickInput;
    public bool prevThrustWasGood;
    public bool prevSteeringWasGood;
    public bool playerHasDualshock;
}
