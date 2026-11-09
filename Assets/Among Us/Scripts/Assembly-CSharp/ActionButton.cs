public class ActionButton : UnityEngine.MonoBehaviour
{
    public UnityEngine.SpriteRenderer graphic;
    public UnityEngine.SpriteRenderer usesRemainingSprite;
    public TMPro.TextMeshPro usesRemainingText;
    public TMPro.TextMeshPro buttonLabelText;
    public TMPro.TextMeshPro cooldownTimerText;
    public ActionMapGlyphDisplay glyph;
    public bool isCoolingDown;
    public Logger logger;
    public bool canInteract;
    public UnityEngine.Vector3 position;
}
