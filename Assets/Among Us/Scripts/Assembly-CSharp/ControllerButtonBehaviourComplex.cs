public class ControllerButtonBehaviourComplex : UnityEngine.MonoBehaviour
{
    public ControllerButtonBehaviourComplex.ActionTriggerType actionTriggerType;
    public ControllerButtonBehaviourComplex.ActionTrigger[] actionTriggers;
    public UnityEngine.GameObject requiredMenuObject;
    public enum ActionTriggerType : int
    {
        Any = 0,
        All = 1,
}
    public struct ActionTrigger
    {
        public RewiredConstsEnum.Action action;
        public ControllerButtonBehaviourComplex.ActionTrigger.ActionType actionType;
        public float axisComparisonValue;
        public enum ActionType : int
        {
            Axis_GEqual = 0,
            Axis_LEqual = 1,
            Button_Down = 2,
}
}
}
