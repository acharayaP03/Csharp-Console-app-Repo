namespace StrategicDesignPattren;


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
    public List<int> FilterBy(Func<int, bool> predicate, List<int> numbers)
    {
        var result = new List<int>();
        foreach (var number in numbers)
        {
            if (predicate(number))
            {
                result.Add(number);
            }
        }

        return result;
    }
}