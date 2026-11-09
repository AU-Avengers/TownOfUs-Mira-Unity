public class KeyMinigame : Minigame
{
    public KeySlotBehaviour[] Slots;
    public int keyState;
    public UnityEngine.SpriteRenderer KeyImage;
    public UnityEngine.Sprite normalImage;
    public UnityEngine.Sprite insertImage;
    public UnityEngine.BoxCollider2D key;
    public int targetSlotId;
    public Controller controller;
    public UnityEngine.AudioClip KeyGrab;
    public UnityEngine.AudioClip KeyInsert;
    public UnityEngine.AudioClip KeyOpen;
    public UnityEngine.AudioClip KeyTurn;
    public TouchpadBehavior touchpad;
    public UnityEngine.Vector3 initialPos;
    public bool prevHadInput;
    public UnityEngine.Vector2 prevInputDir;
    public float currentAngle;
    public UnityEngine.GameObject moveKeyGlyph;
    public UnityEngine.GameObject turnKeyGlyph;
}
