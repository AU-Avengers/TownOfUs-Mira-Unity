public class SecurityLogger : UnityEngine.MonoBehaviour
{
    public SecurityLogBehaviour LogParent;
    public SecurityLogBehaviour.SecurityLogLocations MyLocation;
    public float Cooldown;
    public UnityEngine.SpriteRenderer Image;
    public UnityEngine.BoxCollider2D Sensor;
    public System.Single[] Timers;
    public UnityEngine.ContactFilter2D filter;
}
