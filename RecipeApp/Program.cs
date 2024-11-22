

using RecipeApp;
using RecipeApp.Repositories;
using RecipeApp.UserRecipeConsoleInteraction;
using RecipeApp.Utils;

RecipesConsoleUserInteractions.PrintApplicationStartingLabel();
string projectDirectory = Environment.CurrentDirectory;
string filePath = Path.Combine(projectDirectory, "recipe.txt");

IngredientsRegister ingredientsRegister = new();

CookBookRecipes cookBookRecipes = new(
        new RecipesRepository(
                new StringsTextualRepository(),
                ingredientsRegister
            ),
        new RecipesConsoleUserInteractions(
                ingredientsRegister
            )
    );
cookBookRecipes.Run(filePath);
