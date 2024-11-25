namespace C__Console_Apps.VitualMethodsOverriding;

public class NumbersSumCalculator
{
    public int CalculateSum(List<int> listOfNumbers)
    {
        int sum = 0;

        foreach (var number in listOfNumbers)
        {

            if (ShouldAllowOnlyPositiveNumbers(number))
            {
                sum += number;
            }

            sum += number;
        }
        return sum;
    }

    protected virtual bool ShouldAllowOnlyPositiveNumbers(int number) => false;
}