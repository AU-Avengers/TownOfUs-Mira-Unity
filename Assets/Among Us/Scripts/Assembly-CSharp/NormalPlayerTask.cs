public class NormalPlayerTask : PlayerTask
{
    public NormalPlayerTask.TaskLength Length;
    public int taskStep;
    public int MaxStep;
    public bool ShowTaskStep;
    public bool ShowTaskTimer;
    public NormalPlayerTask.TimerState TimerStarted;
    public float TaskTimer;
    public System.Byte[] Data;
    public ArrowBehaviour Arrow;
    public bool useMultipleText;
    public int maxNumStepsStage1;
    public StringNames textStage1;
    public StringNames textStage2;
    public bool arrowSuspended;
    public enum TaskLength : int
    {
        None = 0,
        Common = 1,
        Short = 2,
        Long = 3,
}
    public enum TimerState : int
    {
        NotStarted = 0,
        Started = 1,
        Finished = 2,
}
}
