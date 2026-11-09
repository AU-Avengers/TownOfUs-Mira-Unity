public class TextBoxTMP : UnityEngine.MonoBehaviour, IFocusHolder
{
    public bool allowAllCharacters;
    public string text;
    public string compoText;
    public float TextHeight;
    public int characterLimit;
    public TMPro.TextMeshPro outputText;
    public UnityEngine.SpriteRenderer Background;
    public UnityEngine.MeshRenderer Pipe;
    public float pipeBlinkTimer;
    public bool ClearOnFocus;
    public bool ForceUppercase;
    public UnityEngine.UI.Button.ButtonClickedEvent OnEnter;
    public UnityEngine.UI.Button.ButtonClickedEvent OnChange;
    public UnityEngine.UI.Button.ButtonClickedEvent OnFocusLost;
    public UnityEngine.TouchScreenKeyboard keyboard;
    public bool AllowSymbols;
    public bool AllowEmail;
    public bool IpMode;
    public bool AllowPaste;
    public bool Hidden;
    public UnityEngine.Collider2D[] colliders;
    public bool hasFocus;
    public System.Text.StringBuilder tempTxt;
    public UnityEngine.SpriteRenderer sendButtonGlyph;
}
