namespace FileContentParser.UserInteraction;

public interface IUserConsoleInteraction
{
    void PrintApplicationStartingLabel(string applicationLabel, string applicationSubtitle);
    string? ReadValidFilePath();

    void PrintMessage(string message);

    void PrintError(string message);
}