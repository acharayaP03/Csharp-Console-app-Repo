
/// <summary>
/// Defines the <see cref="NumbersFilter" />
/// </summary>
public class NumbersFilter
{
    /// <summary>
    /// The FilterBy
    /// </summary>
    /// <param name="filteringType">The filteringType<see cref="string"/></param>
    /// <param name="numbers">The numbers<see cref="List{int}"/></param>
    /// <returns>The <see cref="List{int}"/></returns>
    public List<int> FilterBy(string filteringType, List<int> numbers)
    {
        switch (filteringType.ToLower())
        {
            case "even":
                return Select(numbers, number => number % 2 == 0);
            case "odd":
                return Select(numbers, number => number % 2 is not 0);
            case "positive":
                return Select(numbers, number => number > 0);
            case "negative":
                return Select(numbers, number => number < 0);
            default:
                throw new NotSupportedException(
                    $"{filteringType} is not a valid filter");
        }
    }

    public List<int> Select(List<int> numbers, Func<int, bool> predicate)
    {
        var result = new List<int>();
        foreach (var number in numbers)
        {
            if(predicate(number))
            {
                result.Add(number);
            }
        }

        return result;
    }
}
