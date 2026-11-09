public class RewiredCategoryEnabler : UnityEngine.MonoBehaviour
{
    public bool applyDefaultMapState;
    public RewiredCategoryEnabler.RewiredCategoryState[] defaultStates;
    [System.Serializable]
    public class RewiredCategoryState : System.Object
    {
        public string name;
        public bool enabled;
}
}
