public class FungleSecurityCamera : UnityEngine.MonoBehaviour
{
    public System.Action<UnityEngine.Collision2D> OnCollision;
    public System.Action<UnityEngine.Collision2D> OnExitCollision;
    public UnityEngine.Camera cam;
    public UnityEngine.Rigidbody2D rigidbody;
}
