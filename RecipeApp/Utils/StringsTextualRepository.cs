namespace RecipeApp.Utils;

public class StringsTextualRepository : IStringsRepository
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
