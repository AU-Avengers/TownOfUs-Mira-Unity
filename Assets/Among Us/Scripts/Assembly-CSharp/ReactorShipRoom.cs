public class ReactorShipRoom : SkeldShipRoom, IReactorShipRoom
{
    public UnityEngine.Sprite normalManifolds;
    public UnityEngine.Sprite meltdownManifolds;
    public UnityEngine.SpriteRenderer Manifolds;
    public UnityEngine.AnimationClip normalReactor;
    public UnityEngine.AnimationClip meltdownReactor;
    public PowerTools.SpriteAnim Reactor;
    public UnityEngine.AnimationClip normalHighFloor;
    public UnityEngine.AnimationClip meltdownHighFloor;
    public PowerTools.SpriteAnim HighFloor;
    public UnityEngine.AnimationClip normalMidFloor;
    public UnityEngine.AnimationClip meltdownMidFloor;
    public PowerTools.SpriteAnim MidFloor1;
    public PowerTools.SpriteAnim MidFloor2;
    public UnityEngine.AnimationClip normalLowFloor;
    public UnityEngine.AnimationClip meltdownLowFloor;
    public PowerTools.SpriteAnim LowFloor;
    public UnityEngine.AnimationClip[] normalPipes;
    public UnityEngine.AnimationClip[] meltdownPipes;
    public PowerTools.SpriteAnim[] Pipes;
    public SupressorBehaviour[] Supressors;
    public UnityEngine.MeshRenderer Orb;
    public Rotater OrbGlass;
    public ChainBehaviour[] Arms;
}
