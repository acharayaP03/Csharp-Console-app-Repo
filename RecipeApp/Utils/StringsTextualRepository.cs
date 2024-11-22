using System.Text.Json;

namespace RecipeApp.Utils;

public class StringsTextualRepository : IStringsTextualRepository
{
    private static readonly string Separator = Environment.NewLine;

    public List<string> Read(string filePath)
    {

        if (File.Exists(filePath))
        {
            var fileContents = File.ReadAllText(filePath);
            return fileContents.Split(Separator).ToList();
        }

        return new List<string>();
    }

    public void Write(string filePath, List<string> contents)
    {
        File.WriteAllText(filePath, string.Join(Separator, contents));
    }

}

public interface IStringsJsonRepository
{
    List<string> Read(string filePath);
    void Write(string filePath, List<string> contents);
}

public class StringsJsonRepository : IStringsJsonRepository
{
    public List<string> Read(string filePath)
    {

        if (File.Exists(filePath))
        {
            var fileContents = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<string>>(fileContents);
        }

        return new List<string>();
    }

    public void Write(string filePath, List<string> contents)
    {
        File.WriteAllText(filePath, JsonSerializer.Serialize(contents));
    }

}