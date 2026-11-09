public class TestFrisbeeMinigame : Minigame
{
    public float pickUpAnalogThresshold;
    public PassiveButton stuckFrisbee;
    public UnityEngine.Collider2D throwableFrisbee;
    public PowerTools.SpriteAnim sparkle;
    public UnityEngine.GameObject throwControllerGlyph;
    public float totalSeconds;
    public UnityEngine.Transform finalFrisbeePosition;
    public UnityEngine.AudioClip grabSound;
    public UnityEngine.AudioClip throwSound;
    public UnityEngine.AudioClip twinkleSound;
    public Controller controller;
    public UnityEngine.Vector3 originalFrisbeePosition;
    public UnityEngine.Vector3 throwStartPosition;
    public bool pickedUp;
    public bool thrown;
    public float time;
    public bool isCompleting;
}
