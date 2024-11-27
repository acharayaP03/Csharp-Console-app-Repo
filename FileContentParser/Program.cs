

UserConsoleInteraction.PrintApplicationStartingLabel(
    "File formatter",
    "Type in your file location to format file."
    );

var userInput = Console.ReadLine();

Console.WriteLine("User input " + userInput );

Console.ReadKey();


public class UserConsoleInteraction
{


    public static void PrintApplicationStartingLabel(string applicationLabel, string applicationSubtitle)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"************* Welcome to {applicationLabel} *************");
        Console.ResetColor();
        Console.WriteLine($"{applicationSubtitle}");

    }
}