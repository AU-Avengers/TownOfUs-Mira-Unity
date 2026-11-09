public class FriendsListConfirmMenu : UnityEngine.MonoBehaviour
{
    public TMPro.TextMeshPro PopUpText;
    public FriendsListConfirmMenu.ConfirmationStatus confirmStatus;
    public UiElement BackButton;
    public UiElement DefaultButtonSelected;
    public enum ConfirmationStatus : int
    {
        Waiting = 0,
        Yes = 1,
        No = 2,
}
    public enum ActionType : int
    {
        Friend = 0,
        Block = 1,
        Lobby = 2,
        Unfriend = 3,
        Unblock = 4,
}
}
