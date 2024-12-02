namespace C__Console_Apps.ExceptionHendeling;

public static class ExceptionFiltering
{
    public static IEnumerable<string> SendHttpRequest(string requestUrl)
    {
        return ["test", "test1"];
    }
}


// These are test data
//try
//{
//    int number = ExplicitException.ParseStringToInt(input);
//    var result = 10 / number;
//    Console.WriteLine("String successfully parsed, the result is " + number);
//    Console.WriteLine($"10 / {number} is " + result);
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Wrong format provided " + ex.Message);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Cannot be divided by 0. " + ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine("An exception occurred. " + ex.Message);
//}
//finally
//{
//    Console.WriteLine("Cleaning up all operation");
//}


// Exception filtering with "when"
//try
//{
//    var dataFromWeb = ExceptionFiltering.SendHttpRequest("www.someAddress.com/get/someResource");
//}
//catch (HttpRequestException ex) when (ex.Message == "403")
//{
//    Console.WriteLine($"It was forbidden to access the resource");
//    throw;
//}
//catch (HttpRequestException ex) when (ex.Message == "404")
//{
//    Console.WriteLine("The resource was not found.");
//    throw;
//}



// Global try catch
//try
//{
//    var transaction = new TransactionData
//    {
//        Sender = "Alice",
//        Receiver = "Bob",
//        Amount = 100m
//    };

//    throw new InvalidTransactionException("Negative transaction amount is not allowed.", transaction);
//}
//catch (InvalidTransactionException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//    Console.WriteLine($"Transaction Details: Sender = {ex.TransactionData.Sender}, Receiver = {ex.TransactionData.Receiver}, Amount = {ex.TransactionData.Amount}");
//}