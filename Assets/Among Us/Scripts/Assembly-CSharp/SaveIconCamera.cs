public class SaveIconCamera : DestroyableSingleton
{
    public UnityEngine.Camera cam;
    public ConditionalRenderTexture platformRenderTextures;
    public UnityEngine.RenderTexture targetTexture;
    public PlayerControl saveIconDummy;
    public UnityEngine.LayerMask layerToRenderWith;
    public int layerIndex;
}
