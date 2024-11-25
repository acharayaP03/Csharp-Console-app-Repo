namespace C__Console_Apps.VitualMethodsOverriding;
public class AddOnlyPositiveNumbers : NumbersSumCalculator
{
    protected override bool ShouldAllowOnlyPositiveNumbers(int number) => number > 0;
}