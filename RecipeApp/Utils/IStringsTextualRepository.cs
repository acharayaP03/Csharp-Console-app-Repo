namespace RecipeApp.Utils;

public interface IStringsTextualRepository
{
    List<string> Read(string filePath);
    void Write(string filePath, List<string> contents);
}