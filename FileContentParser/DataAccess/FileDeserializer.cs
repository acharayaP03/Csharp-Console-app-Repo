using FileContentParser.Model;
using FileContentParser.UserInteraction;
using System.Text.Json;

namespace FileContentParser.DataAccess;

public class FileDeserializer : IFileDeserializer
{
    private readonly IUserConsoleInteraction _userConsoleInteraction;

    public FileDeserializer(IUserConsoleInteraction userConsoleInteraction)
    {
        _userConsoleInteraction = userConsoleInteraction;
    }

    public IEnumerable<FileContents> DeserializeFileContents(string? fileName, string contents)
    {
        try
        {
            return JsonSerializer.Deserialize<IEnumerable<FileContents>>(contents);
        }
        catch (JsonException ex)
        {
            _userConsoleInteraction.PrintError($"JSON on {fileName} file was not in a valid format. JSON body.");
            _userConsoleInteraction.PrintError(contents);

            throw new JsonException($"{ex.Message}, The file that caused this issue is: {fileName}", ex);
        }
    }
}