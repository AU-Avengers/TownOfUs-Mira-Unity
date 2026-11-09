public class CrystalMinigame : Minigame
{
    public CrystalBehaviour[] CrystalPieces;
    public CrystalBehaviour[] Shuffed;
    public UnityEngine.Transform[] CrystalSlots;
    public FloatRange XRange;
    public float TrayY;
    public UnityEngine.AudioClip[] PickUpSounds;
    public UnityEngine.AudioClip AttachSound;
    public Controller myController;
    public bool prevHadStick;
    public bool prevHadButton;
    public int prevSelectedCrystal;
    public int selectedCrystal;
}
