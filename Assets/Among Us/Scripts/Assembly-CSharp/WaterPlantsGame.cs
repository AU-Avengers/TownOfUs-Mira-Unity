public class WaterPlantsGame : Minigame
{
    public UnityEngine.GameObject stage1;
    public UnityEngine.GameObject stage2;
    public UnityEngine.AudioClip CanGrabSound;
    public PassiveButton WaterCan;
    public UnityEngine.SpriteRenderer[] Plants;
    public UnityEngine.AudioClip WaterPlantSound;
    public UnityEngine.AudioClip[] PlantGrowSounds;
    public UnityEngine.AudioClip[] PlantFinishedSounds;
    public TMPro.TextMeshPro FloatText;
    public UnityEngine.Transform[] Locations;
    public UnityEngine.Transform selectorObject;
    public UnityEngine.GameObject grabCanSubObject;
    public UnityEngine.GameObject holdingCanSubObject;
    public UnityEngine.GameObject waterPlantsSubObject;
    public Controller c;
    public UnityEngine.SpriteRenderer[] playerHandObjects;
    public UnityEngine.ParticleSystem waterParticles;
    public UnityEngine.GameObject greenDot;
}
