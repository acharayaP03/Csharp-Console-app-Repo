
using System.Text.Json;

namespace RecipeApp.DataAccess;

public class StringsJsonRepository : StringsRepository
{

    protected override string StringsToText(List<string> fileContents)
    {
        return JsonSerializer.Serialize(fileContents);
    }

    protected override List<string> TextToStrings(string fileContents)
    {
        return JsonSerializer.Deserialize<List<string>>(fileContents);
    }
}