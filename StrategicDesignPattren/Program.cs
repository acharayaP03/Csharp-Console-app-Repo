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
var result = new Filter().FilterBy(filteringStrategy, numbers);
PrintAvailableNumbers(result);


//Now we can pass the list containing string
var words = new[] { "zebra", "ostrich", "otter" };
var oWords = new Filter().FilterBy(
        word => word.StartsWith("o"), words
    );

Console.WriteLine($"Words starts with o are {string.Join(", ", oWords)}");

Console.ReadKey();
