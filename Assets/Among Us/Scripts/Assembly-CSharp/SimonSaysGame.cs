public class SimonSaysGame : Minigame
{
    public UnityEngine.Color gray;
    public UnityEngine.Color blue;
    public UnityEngine.Color red;
    public UnityEngine.Color green;
    public UnityEngine.SpriteRenderer[] LeftSide;
    public UnityEngine.SpriteRenderer[] Buttons;
    public UnityEngine.SpriteRenderer[] LeftLights;
    public UnityEngine.SpriteRenderer[] RightLights;
    public float flashTime;
    public float userButtonFlashTime;
    public UnityEngine.AudioClip ButtonPressSound;
    public UnityEngine.AudioClip FailSound;
    public UnityEngine.Transform selectorHighlightObject;
    public float diagonalRoundingWidth;
    public float inputAngleIndex;
    public int roundDownIndex;
    public int roundUpIndex;
    public System.Int32[] orderedButtonIndices;
}
