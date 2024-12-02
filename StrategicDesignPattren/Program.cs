using StrategicDesignPattren;

Console.WriteLine("************* Strategic design pattern *************");
Console.WriteLine("Avaialbel numbers are below: " + Environment.NewLine);

var numbers = new List<int>
{
    10, 20, -144, 16, 55, 19, 22
};
var filteringStrategySelector = new FilteringStrategySelector();

PrintAvailableNumbers(numbers);

Console.WriteLine("Select filter: ");
Console.WriteLine(
    string.Join(Environment.NewLine,
            filteringStrategySelector.FilteringStrategiesNames
        )
    );

var userInput = Console.ReadLine();

void PrintAvailableNumbers(IEnumerable<int> numbers)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(string.Join(", ", numbers));
    Console.ResetColor();
}

var filteringStrategy = filteringStrategySelector.Select(userInput);
List<int> result = new NumbersFilter().FilterBy(filteringStrategy, numbers);
PrintAvailableNumbers(result);

Console.ReadKey();
