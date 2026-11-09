public class RoastMarshmallowStickMinigame : Minigame
{
    public UnityEngine.BoxCollider2D[] spawnRegions;
    public UnityEngine.Transform stickTransform;
    public UnityEngine.GameObject stickSprite;
    public UnityEngine.ParticleSystem stickParticles;
    public UnityEngine.Transform[] otherRandomObjects;
    public PassiveButton stickButton;
    public UnityEngine.Transform hand;
    public RoastMarshmallowStickMinigame.State state;
    public enum State : int
    {
        Ready = 0,
        Ending = 1,
        Ended = 2,
}
}
