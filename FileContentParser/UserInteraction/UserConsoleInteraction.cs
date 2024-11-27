using FileContentParser.UserInteraction;

public class UserConsoleInteraction : IUserConsoleInteraction
{

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }    
    
    public void PrintError(string message)
    {
        var originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);

        Console.ForegroundColor = originalColor;
    }
    public void PrintApplicationStartingLabel(string applicationLabel, string applicationSubtitle)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"************* Welcome to {applicationLabel} *************");
        Console.ResetColor();
        Console.WriteLine($"{applicationSubtitle}");
    }


    public string? ReadValidFilePath()
    {
        var isFilePathValid = false;
        //string contents = default; // in the case if we do not know the default type,
        //we can use default. if the type is defined before variable is initialized, just assign defalut or else below
        var fileName = default(string);
        do
        {
            fileName = Console.ReadLine();

            if (fileName is null)
            {
                Console.WriteLine("Sorry!, Filename cannot be empty. please provide file name to be formatted. file name is null.");
            }
            else if (fileName == string.Empty)
            {
                Console.WriteLine("Sorry!, Filename cannot be empty. please provide file name to be formatted.");
            }
            else if (!File.Exists(fileName))
            {
                Console.WriteLine("Sorry!, Filename could not be found..");
            }
            else
            {
                isFilePathValid = true;
            }
        } while (!isFilePathValid);
        return fileName;
    }
}
