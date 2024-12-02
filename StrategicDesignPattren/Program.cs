Console.WriteLine("************* Strategic design pattern *************");
Console.WriteLine("Avaialbel numbers are below: " + Environment.NewLine);

var numbers = new List<int>
{
    10, 20, -144, 16, 55, 19, 22
};

PrintAvailableNumbers(numbers);

Console.WriteLine(@"Select Filter: 
Even
Odd
Positive
Negative
");

var userInput = Console.ReadLine();

void PrintAvailableNumbers(IEnumerable<int> numbers)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(string.Join(", ", numbers));
    Console.ResetColor();
}

List<int> result = new NumbersFilter().FilterBy(userInput, numbers);
PrintAvailableNumbers(result);

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

Console.ReadKey();
