

using RecipeApp;
using RecipeApp.DataAccess;
using RecipeApp.Repositories;
using RecipeApp.UserRecipeConsoleInteraction;
using RecipeApp.Utils;

RecipesConsoleUserInteractions.PrintApplicationStartingLabel();

const FileFormat Format = FileFormat.Json;

IStringsRepository userSelctedRepository = Format == FileFormat.Json
    ? new StringsJsonRepository() : new StringsTextualRepository();

const string FileName = "recipes";

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



