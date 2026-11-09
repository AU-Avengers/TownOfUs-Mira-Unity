public class SensorDoor : UnityEngine.MonoBehaviour
{
    public UnityEngine.SpriteRenderer LeftSide;
    public UnityEngine.SpriteRenderer RightSide;
    public float ActivationDistance;
    public bool Opening;
    public float OpenDuration;
    public float openTimer;
    public UnityEngine.AudioClip OpenSound;
    public UnityEngine.AudioClip CloseSound;
}
