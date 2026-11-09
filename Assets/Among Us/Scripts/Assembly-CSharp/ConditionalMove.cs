public class ConditionalMove : UnityEngine.MonoBehaviour
{
    public ConditionalMove.MoveForPlatforms[] moveForPlatforms;
    public struct MoveForPlatforms
    {
        public UnityEngine.RuntimePlatform runtimePlatform;
        public UnityEngine.Vector3 offset;
}
}
