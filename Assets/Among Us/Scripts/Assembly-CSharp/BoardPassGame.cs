public class BoardPassGame : Minigame
{
    public UnityEngine.SpriteRenderer renderer;
    public UnityEngine.SpriteRenderer pass;
    public UnityEngine.Sprite passBack;
    public TMPro.TextMeshPro NameText;
    public UnityEngine.SpriteRenderer ImageBg;
    public UnityEngine.SpriteRenderer Image;
    public UnityEngine.Sprite[] Photos;
    public PassiveButton pullButton;
    public PassiveButton flipButton;
    public UnityEngine.SpriteRenderer Scanner;
    public UnityEngine.Sprite ScannerAccept;
    public UnityEngine.Sprite ScannerScanning;
    public UnityEngine.Sprite ScannerWaiting;
    public UnityEngine.Collider2D Sensor;
    public UnityEngine.Collider2D BarCode;
    public UnityEngine.AudioClip slideinSound;
    public UnityEngine.AudioClip flipSound;
    public UnityEngine.AudioClip scanStartSound;
    public UnityEngine.AudioClip scanSound;
    public UnityEngine.Coroutine blinky;
    public Controller controller;
    public TouchpadBehavior touchpad;
    public bool prevHadInput;
    public float rotateAngle;
    public UnityEngine.Vector2 prevStickDir;
    public bool enableControllerPassMovement;
    public bool grabbed;
}
