

using RecipeApp;
using RecipeApp.DataAccess;
using RecipeApp.Repositories;
using RecipeApp.UserRecipeConsoleInteraction;
using RecipeApp.Utils;


//Applying global Exception handler
try
{

    RecipesConsoleUserInteractions.PrintApplicationStartingLabel();

    IngredientsRegister ingredientsRegister = new();
    const FileFormat Format = FileFormat.Json;

    IStringsRepository userSelctedRepository = Format == FileFormat.Json
        ? new StringsJsonRepository() : new StringsTextualRepository();

    const string FileName = "recipes";

    var fileMetadata = new FileMetadata(FileName,
        Format);

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
} 
catch(Exception ex)
{
    Console.WriteLine("Sorry! The application experienced" +
        " an unexpected error and will have to be closed." +
        "The error message: " + ex.Message
        );

    Console.WriteLine("Please press any key to exit out of app.");
    Console.ReadKey();
}




