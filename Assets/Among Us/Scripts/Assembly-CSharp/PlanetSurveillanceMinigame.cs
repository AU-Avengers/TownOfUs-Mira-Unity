public class PlanetSurveillanceMinigame : Minigame
{
    public UnityEngine.Camera Camera;
    public UnityEngine.GameObject Viewables;
    public UnityEngine.MeshRenderer ViewPort;
    public TMPro.TextMeshPro LocationName;
    public TMPro.TextMeshPro SabText;
    public UnityEngine.RenderTexture texture;
    public UnityEngine.MeshRenderer FillQuad;
    public UnityEngine.Material DefaultMaterial;
    public UnityEngine.Material StaticMaterial;
    public bool isStatic;
    public SurvCamera[] survCameras;
    public UnityEngine.Transform DotParent;
    public UnityEngine.SpriteRenderer[] Dots;
    public UnityEngine.Sprite DotEnabled;
    public UnityEngine.Sprite DotDisabled;
    public int currentCamera;
    public UnityEngine.AudioClip ChangeSound;
}
