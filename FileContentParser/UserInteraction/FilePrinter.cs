using FileContentParser.Model;

namespace FileContentParser.UserInteraction;

public class FilePrinter : IFilePrinter
{
    private readonly IUserConsoleInteraction _userConsoleInteraction;

    public FilePrinter(IUserConsoleInteraction userConsoleInteraction)
    {
        _userConsoleInteraction = userConsoleInteraction;
    }

    public void Print(List<FileContents> formatedContents)
    {
        if (formatedContents.Count > 0)
        {
            _userConsoleInteraction.PrintMessage(Environment.NewLine + "File read contents are:");
            foreach (var fileContent in formatedContents)
            {
                _userConsoleInteraction.PrintMessage(fileContent.ToString());
            }
        }
        else
        {
            _userConsoleInteraction.PrintMessage("No contents available from the file.");
        }
    }
}