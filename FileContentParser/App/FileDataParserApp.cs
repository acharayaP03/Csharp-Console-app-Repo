using FileContentParser.DataAccess;
using FileContentParser.UserInteraction;

namespace FileContentParser.App;

public class FileDataParserApp
{

    private readonly IUserConsoleInteraction _userConsoleInteraction;
    private readonly IFilePrinter _filePrinter;
    private readonly IFileDeserializer _fileDeserializer;
    private readonly ILocalFileReader _localFileReader;

    public FileDataParserApp(IUserConsoleInteraction userConsoleInteraction, IFilePrinter filePrinter, IFileDeserializer fileDeserializer, ILocalFileReader localFileReader)
    {
        _userConsoleInteraction = userConsoleInteraction;
        _filePrinter = filePrinter;
        _fileDeserializer = fileDeserializer;
        _localFileReader = localFileReader;
    }

    public void RunApp()
    {
        string? fileName = _userConsoleInteraction.ReadValidFilePath();

        var contents = _localFileReader.Read(fileName);
        var formatedContents = _fileDeserializer.DeserializeFileContents(fileName, contents);

        _filePrinter.Print(formatedContents);
    }

}