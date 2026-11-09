public class NavigationMinigame : Minigame
{
    public UnityEngine.MeshRenderer TwoAxisImage;
    public UnityEngine.SpriteRenderer CrossHairImage;
    public UnityEngine.Collider2D hitbox;
    public Controller myController;
    public UnityEngine.Vector2 crossHair;
    public UnityEngine.Vector2 half;
    public UnityEngine.Vector2 initialPos;
    public TouchpadBehavior touchpad;
    public bool prevHadInput;
}
