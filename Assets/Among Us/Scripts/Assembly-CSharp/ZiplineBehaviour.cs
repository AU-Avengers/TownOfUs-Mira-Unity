public class ZiplineBehaviour : UnityEngine.MonoBehaviour
{
    public UnityEngine.Transform handleTop;
    public UnityEngine.Transform handleBottom;
    public UnityEngine.Transform landingPositionBottom;
    public UnityEngine.Transform landingPositionTop;
    public UnityEngine.Transform dropPositionBottom;
    public UnityEngine.Transform dropPositionTop;
    public float upTravelTime;
    public float downTravelTime;
    public float timeJump;
    public UnityEngine.AnimationCurve jumpZiplineCurve;
    public UnityEngine.AnimationCurve jumpZiplineCurveBottom;
    public UnityEngine.AnimationCurve jumpZiplineHandCurve;
    public ObjectPoolBehavior handPool;
    public UnityEngine.Transform upHandPosition;
    public UnityEngine.Transform downHandPosition;
    public UnityEngine.AudioClip attachSound;
    public UnityEngine.AudioClip detachSound;
    public UnityEngine.AudioClip upSound;
    public UnityEngine.AudioClip downSound;
    public UnityEngine.AudioClip downLoopSound;
    public Logger logger;
    public ZiplineConsole lastUsedConsole;
}
