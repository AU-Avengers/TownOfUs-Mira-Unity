public class JoinGameButton : UnityEngine.MonoBehaviour, IConnectButton
{
    public UnityEngine.AudioClip IntroMusic;
    public TextBoxTMP GameIdText;
    public TMPro.TextMeshPro gameNameText;
    public float timeRecieved;
    public UnityEngine.SpriteRenderer FillScreen;
    public PowerTools.SpriteAnim connectIcon;
    public UnityEngine.AnimationClip connectClip;
    public NetworkModes NetworkMode;
    public string netAddress;
}
