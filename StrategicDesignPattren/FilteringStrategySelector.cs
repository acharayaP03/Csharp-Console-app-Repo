namespace StrategicDesignPattren;


/// <summary>
/// Defines the <see cref="NumbersFilter" />
/// </summary>
public class FilteringStrategySelector
{
    private readonly Dictionary<string, Func<int, bool>> _filteringStrategy = new Dictionary<string, Func<int, bool>>
    {
        ["Even"] = number => number % 2 == 0,
        ["Odd"] = number => number % 2 is not 0,
        ["Positive"] = number => number > 0,
        ["Negative"] = number => number < 0
    };

    public IEnumerable<string> FilteringStrategiesNames => _filteringStrategy.Keys;
    public Func<int, bool> Select(string filteringType)
    {
        if(!_filteringStrategy.ContainsKey(filteringType))
        {
            throw new NotSupportedException(
                $"{filteringType} is not a valid filter");
        }
        return _filteringStrategy[filteringType];
    }
}