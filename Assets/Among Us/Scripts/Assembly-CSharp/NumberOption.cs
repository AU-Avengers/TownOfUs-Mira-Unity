public class NumberOption : OptionBehaviour
{
    public TMPro.TextMeshPro TitleText;
    public TMPro.TextMeshPro ValueText;
    public float Value;
    public float oldValue;
    public float Increment;
    public FloatRange ValidRange;
    public string FormatString;
    public bool ZeroIsInfinity;
    public NumberSuffixes SuffixType;
}
