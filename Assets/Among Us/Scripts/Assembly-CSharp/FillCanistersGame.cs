public class FillCanistersGame : Minigame
{
    public UnityEngine.Vector3 CanisterAppearPosition;
    public UnityEngine.Vector3 CanisterStartPosition;
    public UnityEngine.Vector3 CanisterDragPosition;
    public UnityEngine.Vector3 CanisterSnapPosition;
    public UnityEngine.Vector3 CanisterAwayPosition;
    public float FillTime;
    public CanisterBehaviour Canister;
    public Controller controller;
    public UnityEngine.AudioClip FillLoop;
    public UnityEngine.AudioClip DropSound;
    public UnityEngine.AudioClip GrabSound;
    public UnityEngine.AudioClip PlugInSound;
    public UnityEngine.AudioClip PlugOutSound;
    public TouchpadBehavior touchpad;
    public bool prevHadInput;
}
