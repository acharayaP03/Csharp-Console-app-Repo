
using FileContentParser;
using FileContentParser.App;
using FileContentParser.DataAccess;
using FileContentParser.Logger;
using FileContentParser.UserInteraction;

IUserConsoleInteraction userConsoleInteraction = new UserConsoleInteraction();

FileDataParserApp app = new(
    userConsoleInteraction,
    new FilePrinter(userConsoleInteraction),
    new FileDeserializer(userConsoleInteraction),
    new LocalFileReader()
);
var errorLogger = new ErrorLogger("errorLog.txt");

try
{
    userConsoleInteraction.PrintApplicationStartingLabel(
        "File formatter",
        "Type in your file location to format file.");
    app.RunApp();
}
catch (Exception ex)
{
    Console.WriteLine($"Sorry, The application has experienced an unexpected error " +
        "and will have to be closed.");

    errorLogger.Log(ex);
}


Console.ReadKey();
