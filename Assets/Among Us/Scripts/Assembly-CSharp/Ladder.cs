public class Ladder : UnityEngine.MonoBehaviour, IUsableCoolDown, IUsable
{
    public System.Byte Id;
    public UnityEngine.SpriteRenderer SpotArea;
    public bool IsTop;
    public Ladder Destination;
    public UnityEngine.AudioClip UseSound;
    public UnityEngine.SpriteRenderer Image;
    public void Use() { }
}
