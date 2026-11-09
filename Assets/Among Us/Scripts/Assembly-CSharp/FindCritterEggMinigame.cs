public class FindCritterEggMinigame : Minigame
{
    public UnityEngine.Transform[] spawnPoints;
    public UnityEngine.Transform egg;
    public PassiveButton eggButton;
    public EggCoveringLeaf[] leaves;
    public UnityEngine.Transform hand;
    public UnityEngine.AudioClip eggGetSfx;
    public float leafSfxPitchRange;
    public UnityEngine.AudioClip[] leafSfx;
    public Controller controller;
    public bool completed;
}
