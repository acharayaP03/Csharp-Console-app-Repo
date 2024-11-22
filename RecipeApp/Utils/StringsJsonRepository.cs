using System.Text.Json;

namespace RecipeApp.Utils;

public class StringsJsonRepository : IStringsRepository
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