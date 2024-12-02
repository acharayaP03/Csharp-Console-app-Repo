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

Console.ReadKey();
