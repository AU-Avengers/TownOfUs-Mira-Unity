public class ExileController : UnityEngine.MonoBehaviour
{
    public TMPro.TextMeshPro ImpostorText;
    public TMPro.TextMeshPro Text;
    public PoolablePlayer Player;
    public UnityEngine.AnimationCurve LerpCurve;
    public float Duration;
    public UnityEngine.AudioClip TextSound;
    public UnityEngine.AudioClip EjectSound;
    public bool useIdleAnim;
    public UnityEngine.Vector3 exileHatPosition;
    public UnityEngine.Vector3 exileVisorPosition;
    public string completeString;
    public GameData.PlayerInfo exiled;
    public SpecialInputHandler specialInputHandler;
}
