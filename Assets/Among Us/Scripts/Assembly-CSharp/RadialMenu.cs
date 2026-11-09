public class RadialMenu : UnityEngine.MonoBehaviour
{
    public UnityEngine.Mesh mesh;
    public UnityEngine.GameObject perButtonTemplateObject;
    public UnityEngine.MeshFilter mf;
    public UnityEngine.MeshRenderer mr;
    public int radialDivisions;
    public float sliceDegreesPerVert;
    public float textPositionDistance;
    public bool angleText;
    public int testRadialDivs;
    public UnityEngine.MaterialPropertyBlock mbp;
    public Controller cont;
    public UnityEngine.Transform arrowRotateHandle;
    public UnityEngine.Transform arrowScaleHandle;
    public UnityEngine.Transform inputGlyph;
    public UnityEngine.Vector3[] buttonCenters;
    public UnityEngine.Vector3[] buttonLeftEdges;
    public UnityEngine.Vector3[] buttonRightEdges;
    public float horizontalSqueezedWidth;
}
