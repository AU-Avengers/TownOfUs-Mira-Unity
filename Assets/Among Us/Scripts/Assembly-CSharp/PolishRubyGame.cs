public class PolishRubyGame : Minigame
{
    public PassiveButton[] Buttons;
    public UnityEngine.SpriteRenderer[] Sparkles;
    public System.Int32[] swipes;
    public UnityEngine.Vector2[] directions;
    public int swipesToClean;
    public UnityEngine.AudioClip[] rubSounds;
    public UnityEngine.AudioClip sparkleSound;
    public UnityEngine.Transform cursorObject;
    public UnityEngine.Transform handWipeObject;
    public UnityEngine.SpriteRenderer[] handSprites;
    public UnityEngine.BoxCollider2D rubyCursorBounds;
    public Controller cont;
    public bool oldCursorOverlapsSmudge;
}
