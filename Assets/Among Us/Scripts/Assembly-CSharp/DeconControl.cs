public class DeconControl : UnityEngine.MonoBehaviour, IUsable
{
    public DeconSystem System;
    public float usableDistance;
    public UnityEngine.SpriteRenderer Image;
    public UnityEngine.AudioClip UseSound;
    public UnityEngine.UI.Button.ButtonClickedEvent OnUse;
    public float cooldown;
    public void Use() { }
}
