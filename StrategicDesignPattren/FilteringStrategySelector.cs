namespace StrategicDesignPattren;


/// <summary>
/// Defines the <see cref="NumbersFilter" />
/// </summary>
public class FilteringStrategySelector
{
    public Func<int, bool> Select(string filteringType)
    {
        switch (filteringType.ToLower())
        {
            case "even":
                return number => number % 2 == 0;
            case "odd":
                return number => number % 2 is not 0;
            case "positive":
                return number => number > 0;
            case "negative":
                return number => number < 0;
            default:
                throw new NotSupportedException(
                    $"{filteringType} is not a valid filter");
        }
    }
}