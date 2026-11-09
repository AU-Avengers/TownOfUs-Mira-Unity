public class LightSource : UnityEngine.MonoBehaviour
{
    public float viewDistance;
    public UnityEngine.Material lightCutawayMaterial;
    public UnityEngine.Mesh lightChildMesh;
    public LightSourceRendererType rendererType;
    public bool useFlashlight;
    public UnityEngine.Material gpuShadowCasterMaterial;
    public int gpuShadowmapResolution;
    public UnityEngine.RenderTextureFormat gpuPreferredRTFormat;
    public int raycastMinRayCount;
    public float raycastTolerance;
    public LightSourceRenderer renderer;
    public UnityEngine.GameObject lightChild;
    public UnityEngine.MeshFilter lightChildMeshFilter;
    public Controller controller;
    public float flashlightSize;
    public UnityEngine.Vector2 lastFlashlightDirection;
    public UnityEngine.Vector3 lightOffset;
    public UnityEngine.Transform touchFlashlightTarget;
}
