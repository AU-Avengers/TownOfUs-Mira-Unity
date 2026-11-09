public class RewindTapeMinigame : Minigame
{
    public float targetTime;
    public float currentTime;
    public UnityEngine.SpriteRenderer LeftWheel;
    public UnityEngine.SpriteRenderer LeftTape;
    public UnityEngine.SpriteRenderer RightWheel;
    public UnityEngine.SpriteRenderer RightTape;
    public TMPro.TextMeshPro TargetText;
    public TMPro.TextMeshPro CurrentText;
    public UnityEngine.SpriteRenderer RewindButton;
    public UnityEngine.Sprite RewindNormal;
    public UnityEngine.Sprite RewindDown;
    public UnityEngine.SpriteRenderer FastFwdButton;
    public UnityEngine.Sprite FastFwdNormal;
    public UnityEngine.Sprite FastFwdDown;
    public UnityEngine.SpriteRenderer PlayButton;
    public UnityEngine.Sprite PlayNormal;
    public UnityEngine.Sprite PlayDown;
    public UnityEngine.SpriteRenderer PauseButton;
    public UnityEngine.Sprite PauseNormal;
    public UnityEngine.Sprite PauseDown;
    public UnityEngine.SpriteRenderer RewindGlyph;
    public UnityEngine.SpriteRenderer FastFwdGlyph;
    public UnityEngine.SpriteRenderer PlayGlyph;
    public UnityEngine.SpriteRenderer PauseGlyph;
    public float upGlyphYPos;
    public float pressedGlyphYPos;
    public UnityEngine.Color upGlyphColor;
    public UnityEngine.Color pressedGlyphColor;
    public float direction;
    public UnityEngine.AudioClip buttonSound;
    public UnityEngine.AudioClip playStartSound;
    public UnityEngine.AudioClip playLoopSound;
    public UnityEngine.AudioClip playStopSound;
    public UnityEngine.AudioSource loopSound;
}
