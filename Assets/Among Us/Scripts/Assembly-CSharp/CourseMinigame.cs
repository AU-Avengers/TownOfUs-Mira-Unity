public class CourseMinigame : Minigame
{
    public CourseStarBehaviour StarPrefab;
    public CourseStarBehaviour[] Stars;
    public UnityEngine.SpriteRenderer DotPrefab;
    public UnityEngine.Sprite DotLight;
    public UnityEngine.SpriteRenderer[] Dots;
    public UnityEngine.Collider2D Ship;
    public CourseStarBehaviour Destination;
    public UnityEngine.Vector3[] PathPoints;
    public int NumPoints;
    public FloatRange XRange;
    public FloatRange YRange;
    public UnityEngine.LineRenderer Path;
    public Controller myController;
    public float lineTimer;
    public CourseMinigame.UIntFloat Converter;
    public UnityEngine.AudioClip SetCourseSound;
    public UnityEngine.AudioClip SetCourseLastSound;
    public TouchpadBehavior touchpad;
    public float initialCurVec;
    public float targetCurVec;
    public struct UIntFloat
    {
        public float FloatValue;
        public int IntValue;
}
}
