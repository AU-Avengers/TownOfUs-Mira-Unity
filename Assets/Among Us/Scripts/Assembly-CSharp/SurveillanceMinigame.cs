public class SurveillanceMinigame : Minigame
{
    public UnityEngine.Camera CameraPrefab;
    public UnityEngine.GameObject Viewables;
    public UnityEngine.MeshRenderer[] ViewPorts;
    public TMPro.TextMeshPro[] SabText;
    public PlainShipRoom[] FilteredRooms;
    public UnityEngine.RenderTexture[] textures;
    public UnityEngine.MeshRenderer FillQuad;
    public UnityEngine.Material DefaultMaterial;
    public UnityEngine.Material StaticMaterial;
    public bool isStatic;
}
