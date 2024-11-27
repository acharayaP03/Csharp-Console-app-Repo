

using Microsoft.VisualBasic;
using System.Text.Json;

var isFileRead = false;
//string contents = default; // in the case if we do not know the default type,
//we can use default. if the type is defined before variable is initialized, just assign defalut or else below
var contents = default(string);
var fileName = default(string);
do
{
    try
    {
        UserConsoleInteraction.PrintApplicationStartingLabel(
        "File formatter",
        "Type in your file location to format file."
        );

        fileName = Console.ReadLine();
        contents = File.ReadAllText(fileName);
        isFileRead = true;

    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine("Sorry!, Filename cannot be empty. please provide file name to be formatted. file name is null.");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Sorry!, Filename cannot be empty. please provide file name to be formatted.");
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine("Sorry!, Filename could not be found..");
    }
} while (!isFileRead);

List<FileContents> formatedContents = default;
try
{
    formatedContents = JsonSerializer.Deserialize<List<FileContents>>(contents);

} catch(JsonException ex)
{
    var originalColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"JSON on {fileName} file was not "
        + $"in a valid format. JSON body.");
    Console.WriteLine(contents);
    Console.ForegroundColor = originalColor;

    throw new JsonException($"{ex.Message}, The file that caused this issue is: {fileName}", ex);
}

if (formatedContents.Count > 0)
{
    Console.WriteLine();
    Console.WriteLine("File read contents are:");
    foreach (var fileContent in formatedContents)
    {
        Console.WriteLine(fileContent);
    }
}

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