public class SpawnInMinigame : Minigame
{
    public SpawnInMinigame.SpawnLocation[] Locations;
    public PassiveButton[] LocationButtons;
    public TMPro.TextMeshPro Text;
    public UnityEngine.AudioClip DefaultRolloverSound;
    public UiElement DefaultButtonSelected;
    public bool gotButton;
    public struct SpawnLocation
    {
        public StringNames Name;
        public UnityEngine.Sprite Image;
        public UnityEngine.AnimationClip Rollover;
        public UnityEngine.AudioClip RolloverSfx;
        public UnityEngine.Vector3 Location;
}
}
