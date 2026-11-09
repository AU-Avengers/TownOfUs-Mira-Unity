public class CloudGenerator : UnityEngine.MonoBehaviour
{
    public UnityEngine.Sprite[] CloudImages;
    public int NumClouds;
    public float Length;
    public float Width;
    public UnityEngine.Vector2 Direction;
    public FloatRange Rates;
    public FloatRange Sizes;
    public bool Depth;
    public float MaxDepth;
    public float ParallaxOffset;
    public float ParallaxStrength;
    public UnityEngine.Vector2[] ExtentCache;
    public UnityEngine.Vector2 NormDir;
    public UnityEngine.Vector2 Tangent;
    public float tanLen;
}
