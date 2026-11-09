public class Controller : System.Object
{
    public Controller.TouchState[] Touches;
    public class TouchState : System.Object
    {
        public UnityEngine.Vector2 ScreenDownAt;
        public UnityEngine.Vector2 ScreenPosition;
        public UnityEngine.Vector2 DownAt;
        public UnityEngine.Vector2 Position;
        public bool WasDown;
        public bool IsDown;
        public bool TouchStart;
        public bool TouchEnd;
        public DragState dragState;
        public bool active;
        public int FingerId;
}
    public enum TouchType : int
    {
        Joystick = 0,
        Mouse = 1,
        Touch = 2,
}
}
