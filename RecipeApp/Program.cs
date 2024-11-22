

using RecipeApp;
using RecipeApp.Repositories;
using RecipeApp.UserRecipeConsoleInteraction;
using RecipeApp.Utils;

RecipesConsoleUserInteractions.PrintApplicationStartingLabel();

const FileFormat Format = FileFormat.Json;

IStringsRepository userSelctedRepository = Format == FileFormat.Json
    ? new StringsJsonRepository() : new StringsTextualRepository();

const string FileName = "recipes";
//var filePath = Format == FileFormat.Json ?
//    $"{FileName}.json" :
//    $"{FileName}.txt";
var fileMetadata = new FileMetadata(FileName,
    Format);

IngredientsRegister ingredientsRegister = new();


CookBookRecipes cookBookRecipes = new(
        new RecipesRepository(
                userSelctedRepository,
                ingredientsRegister
            ),
        new RecipesConsoleUserInteractions(
                ingredientsRegister
            )
    );
cookBookRecipes.Run(fileMetadata.ToPath());

public enum FileFormat
{
    Json,
    Text
}


public class FileMetadata
{
    public string Name { get; set; }
    public FileFormat Format { get;}

    public FileMetadata(string name, FileFormat format)
    {
        Name = name;
        Format = format;
    }


    public string ToPath() => $"{Name}.{Format.AsFileExtension()}";
}

public static class FileFormatExtensions
{
    public static string AsFileExtension(this FileFormat fileFormat) =>
        fileFormat == FileFormat.Json ? "json" : "txt";
}