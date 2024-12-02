






//switch (userInput.ToLower())
//{
//    case "even":
//        result = SelectEven(numbers);
//        break;
//    case "odd":
//        result = SelectOdd(numbers);
//        break;
//    case "positive":
//        result = SelectPositive(numbers);
//        break;
//    case "negative":
//        result = SelectNegative(numbers);
//        break;
//    default:
//        throw new NotSupportedException(
//            $"{userInput} is not a valid filter");
//}

//List<int> SelectEven(List<int> numbers)
//{
//    var result = new List<int>();
//    foreach (var number in numbers)
//    {
//        if (number % 2 == 0)
//        {
//            result.Add(number);
//        }
//    }

//    return result;
//}

//List<int> SelectOdd(List<int> numbers)
//{
//    var result = new List<int>();
//    foreach (var number in numbers)
//    {
//        if (number % 2 != 0)
//        {
//            result.Add(number);
//        }
//    }

//    return result;
//}

//List<int> SelectPositive(List<int> numbers)
//{
//    var result = new List<int>();
//    foreach (var number in numbers)
//    {
//        if (number > 0)
//        {
//            result.Add(number);
//        }
//    }

//    return result;
//}

//List<int> SelectNegative(List<int> numbers)
//{
//    var result = new List<int>();
//    foreach (var number in numbers)
//    {
//        if (number < 0)
//        {
//            result.Add(number);
//        }
//    }

//    return result;
//}

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
                return SelectEven(numbers);
            case "odd":
                return SelectOdd(numbers);
            case "positive":
                return SelectPositive(numbers);

            case "negative":
                return SelectNegative(numbers);
            default:
                throw new NotSupportedException(
                    $"{filteringType} is not a valid filter");
        }
    }

    private List<int> SelectEven(List<int> numbers)
    {
        var result = new List<int>();
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                result.Add(number);
            }
        }

        return result;
    }

    private List<int> SelectOdd(List<int> numbers)
    {
        var result = new List<int>();
        foreach (var number in numbers)
        {
            if (number % 2 != 0)
            {
                result.Add(number);
            }
        }

        return result;
    }

    private List<int> SelectPositive(List<int> numbers)
    {
        var result = new List<int>();
        foreach (var number in numbers)
        {
            if (number > 0)
            {
                result.Add(number);
            }
        }

        return result;
    }

    private List<int> SelectNegative(List<int> numbers)
    {
        var result = new List<int>();
        foreach (var number in numbers)
        {
            if (number < 0)
            {
                result.Add(number);
            }
        }

        return result;
    }
}
