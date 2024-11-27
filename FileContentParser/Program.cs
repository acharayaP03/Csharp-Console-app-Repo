
using FileContentParser;
using System.Text.Json;
FileDataParserApp app = new();
var errorLogger = new ErrorLogger("errorLog.txt");

try
{

    app.RunApp();
}
catch (Exception ex)
{
    Console.WriteLine($"Sorry, The application has experienced an unexpected error " +
        "and will have to be closed.");

    errorLogger.Log(ex);
}


Console.ReadKey();

public class FileDataParserApp
{
    public void RunApp()
    {
        string? fileName = ReadValidFilePathFromUser();

        var contents = File.ReadAllText(fileName);
        List<FileContents> formatedContents = DeserializeFileContents(fileName, contents);

        PrintFileContents(formatedContents);
    }

    private static void PrintFileContents(List<FileContents> formatedContents)
    {
        if (formatedContents.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine("File read contents are:");
            foreach (var fileContent in formatedContents)
            {
                Console.WriteLine(fileContent);
            }
        }
    }

    private static List<FileContents> DeserializeFileContents(string? fileName, string contents)
    {
        try
        {
            return JsonSerializer.Deserialize<List<FileContents>>(contents);
        }
        catch (JsonException ex)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"JSON on {fileName} file was not in a valid format. JSON body.");
            Console.WriteLine(contents);

            Console.ForegroundColor = originalColor;

            throw new JsonException($"{ex.Message}, The file that caused this issue is: {fileName}", ex);
        }
    }

    private static string? ReadValidFilePathFromUser()
    {
        var isFilePathValid = false;
        //string contents = default; // in the case if we do not know the default type,
        //we can use default. if the type is defined before variable is initialized, just assign defalut or else below
        var fileName = default(string);
        do
        {

            UserConsoleInteraction.PrintApplicationStartingLabel(
            "File formatter",
            "Type in your file location to format file."
            );

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

public class FileContents
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public decimal Rating { get; set; }

    public override string ToString()
    {
        return $"Title: {Title}, Released year: {ReleaseYear}, Rating: {Rating}";
    }
}