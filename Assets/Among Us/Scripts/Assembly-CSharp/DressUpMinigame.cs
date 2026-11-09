public class DressUpMinigame : Minigame
{
    public UnityEngine.SpriteRenderer DummyHat;
    public UnityEngine.SpriteRenderer DummyAccessory;
    public UnityEngine.SpriteRenderer DummyClothes;
    public UnityEngine.SpriteRenderer ActualHat;
    public UnityEngine.SpriteRenderer ActualAccessory;
    public UnityEngine.SpriteRenderer ActualClothes;
    public DressUpCosmetic[] buttons;
    public UnityEngine.Sprite[] Hats;
    public UnityEngine.Sprite[] Accessories;
    public UnityEngine.Sprite[] Clothes;
    public UnityEngine.Collider2D hatHitbox;
    public UnityEngine.Collider2D faceHitbox;
    public UnityEngine.Collider2D bodyHitbox;
    public UnityEngine.SpriteRenderer draggable;
    public UnityEngine.AudioClip hatSound;
    public UnityEngine.AudioClip faceSound;
    public UnityEngine.AudioClip clothesSound;
    public UnityEngine.AudioClip correctSound;
    public UnityEngine.AudioClip incorrectSound;
    public UnityEngine.AudioClip finishedSound;
    public Controller controller;
    public UnityEngine.SpriteRenderer grabbyHand;
    public UnityEngine.Transform cursorObject;
}
