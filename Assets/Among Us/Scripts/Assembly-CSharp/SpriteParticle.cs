public class SpriteParticle : UnityEngine.MonoBehaviour
{
    public UnityEngine.Sprite[] Sprites;
    public ParticleInfo[] Particles;
    public System.UInt16[][] TriangleCache;
    public UnityEngine.Vector3[] verts;
    public UnityEngine.Vector2[] uvs;
    public UnityEngine.Mesh mesh;
    public int MaxVerts;
}
