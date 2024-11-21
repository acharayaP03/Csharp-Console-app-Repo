

using RecipeApp;
using RecipeApp.Repositories;
using RecipeApp.UserRecipeConsoleInteraction;
using RecipeApp.Utils;

RecipesConsoleUserInteractions.PrintApplicationStartingLabel();
string projectDirectory = Environment.CurrentDirectory;
string filePath = Path.Combine(projectDirectory, "recipe.txt");

CookBookRecipes cookBookRecipes = new(
        new RecipesRepository(
                new StringsTextualRepository(),
                new IngredientsRegister()
            ),
        new RecipesConsoleUserInteractions(
                new IngredientsRegister()
            )
    );
cookBookRecipes.Run(filePath);
