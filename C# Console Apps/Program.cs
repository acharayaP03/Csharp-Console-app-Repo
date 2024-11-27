using C__Console_Apps.ExceptionHendeling;
using C__Console_Apps.VitualMethodsOverriding;
using Microsoft.VisualBasic;

Console.WriteLine("This Project consist of bundle of C# console applications.");

//Chedder chedder = new();
//var ingredients = new List<Ingredients> { chedder, new Mozzarella(), new Parmesan() };


//foreach (var ingredient in ingredients)
//{
//    Console.WriteLine(ingredient.Name);
//}

//var numbers = new List<int> { 1, 2, 3, -4, 5, 6, 7, -8, 9, 10 , 44, -32, 56, -19};
//bool shouldOnlyAddPositiveNumbers = false;   

//var calculator = shouldOnlyAddPositiveNumbers ? new AddOnlyPositiveNumbers() : new NumbersSumCalculator();

//var sum = calculator.CalculateSum(numbers);

//int seasonNumber = 3;

//Season winter = (Season)seasonNumber; // explicit casting

//Console.WriteLine($"Sum of the numbers is {sum}");

string input = Console.ReadLine();
try
{
    int number = ExplicitException.ParseStringToInt(input);
    var result = 10 / number;
    Console.WriteLine("String successfully parsed, the result is " + number);
    Console.WriteLine($"10 / {number} is " + result);
}
catch (FormatException ex)
{
    Console.WriteLine("Wrong format provided " + ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Cannot be divided by 0. " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An exception occurred. " + ex.Message);
}
finally
{
    Console.WriteLine("Cleaning up all operation");
}


// Exception filtering with "when"
try
{
    var dataFromWeb = ExceptionFiltering.SendHttpRequest("www.someAddress.com/get/someResource");
}
catch (HttpRequestException ex) when (ex.Message == "403")
{
    Console.WriteLine($"It was forbidden to access the resource");
    throw;
}
catch (HttpRequestException ex) when (ex.Message == "404")
{
    Console.WriteLine("The resource was not found.");
    throw;
}


try
{
    var transaction = new TransactionData
    {
        Sender = "Alice",
        Receiver = "Bob",
        Amount = 100m
    };

    throw new InvalidTransactionException("Negative transaction amount is not allowed.", transaction);
}
catch (InvalidTransactionException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
    Console.WriteLine($"Transaction Details: Sender = {ex.TransactionData.Sender}, Receiver = {ex.TransactionData.Receiver}, Amount = {ex.TransactionData.Amount}");
}



Console.ReadKey();


public class InvalidTransactionException : Exception
{
    public TransactionData TransactionData { get; }

    public InvalidTransactionException()
    {
    }

    public InvalidTransactionException(string message) : base(message)
    {
    }

    public InvalidTransactionException(string message, Exception innerException) : base(message, innerException)
    { }

    public InvalidTransactionException(string message, TransactionData transactionData) : base(message)
    {
        TransactionData = transactionData;
    }

    public InvalidTransactionException(string message, TransactionData transactionData, Exception innerException) : base(message, innerException)
    {
        TransactionData = transactionData;
    }
}

    public class TransactionData
    {
        public string Sender { get; init; }
        public string Receiver { get; init; }
        public decimal Amount { get; init; }
    }