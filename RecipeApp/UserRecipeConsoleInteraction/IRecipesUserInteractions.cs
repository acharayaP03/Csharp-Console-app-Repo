using RecipeApp.Recipes;
using RecipeApp.Recipes.Ingredients;

namespace RecipeApp.UserRecipeConsoleInteraction;

public interface IRecipesUserInteractions
{
    void ShowMessage(string message);
    void Exit();

    void PromptToCreateRecipe();

    IEnumerable<Ingredient> ReadIngredientsFromUser();
    void Write(string filePath, List<Recipe> allRecipes);
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
}