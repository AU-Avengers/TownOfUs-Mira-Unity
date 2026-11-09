public class InfectedOverlay : UnityEngine.MonoBehaviour
{
    public MapRoom[] rooms;
    public IActivatable doors;
    public SabotageSystemType sabSystem;
    public ButtonBehavior[] allButtons;
    public ButtonBehavior selectedButton;
    public float currentCooldown;
}
