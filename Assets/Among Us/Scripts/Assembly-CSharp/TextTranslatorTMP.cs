public class TextTranslatorTMP : UnityEngine.MonoBehaviour, ITranslatedText
{
    public StringNames TargetText;
    public string defaultStr;
    public bool ToUpper;
    public bool ResetOnlyWhenNoDefault;
    public UnityEngine.Events.UnityEvent OnTranslate;
}
