namespace C__Console_Apps.Attributes;

[AttributeUsage(AttributeTargets.Property)] // which means only apply to property of any class
public class StringLengthValidateAttribute : Attribute
{
    public int Min { get; }
    public int Max { get; }

    public StringLengthValidateAttribute(int min, int max)
    {
        Min = min;
        Max = max;
    }
}