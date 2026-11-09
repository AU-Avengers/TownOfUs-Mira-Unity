public struct ControllerNavigation
{
    public ControllerNavigation.Mode mode;
    public UiElement selectOnUp;
    public UiElement selectOnDown;
    public UiElement selectOnLeft;
    public UiElement selectOnRight;
    public enum Mode : int
    {
        Automatic = 0,
        Explicit = 1,
}
}
