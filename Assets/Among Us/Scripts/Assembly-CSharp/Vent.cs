public class Vent : UnityEngine.MonoBehaviour, IUsable
{
    public int Id;
    public Vent Left;
    public Vent Right;
    public Vent Center;
    public ButtonBehavior[] Buttons;
    public UnityEngine.GameObject[] CleaningIndicators;
    public UnityEngine.AnimationClip EnterVentAnim;
    public UnityEngine.AnimationClip ExitVentAnim;
    public UnityEngine.Vector3 Offset;
    public float spreadAmount;
    public float spreadShift;
    public UnityEngine.SpriteRenderer myRend;
    public PowerTools.SpriteAnim myAnim;
    public int numFramesUntilPlayerDisappearsOnEnter;
    public int numFramesUntilPlayerReappearsOnExit;
    public UnityEngine.GameObject additionalExitAnimation;
    public void Use() { }
}
