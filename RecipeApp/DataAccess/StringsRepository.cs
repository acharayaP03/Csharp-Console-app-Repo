namespace RecipeApp.DataAccess;

public abstract class StringsRepository : IStringsRepository
{
    public List<string> Read(string filePath)
    {

        if (File.Exists(filePath))
        {
            var fileContents = File.ReadAllText(filePath);
            return TextToStrings(fileContents);
        }

        return new List<string>();
    }

    protected abstract List<string> TextToStrings(string fileContents);
    //fileContents.Split(Separator).ToList(), this is the only logic that will be used in derived class

    public void Write(string filePath, List<string> contents)
    {
        File.WriteAllText(filePath, StringsToText(contents));
    }
    protected abstract string StringsToText(List<string> fileContents);
    //string.Join(Separator, contents)

}
