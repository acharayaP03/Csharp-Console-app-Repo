using RecipeApp.Recipes;

namespace RecipeApp.UserRecipeConsoleInteraction;

public interface IRecipesUserInteractions
{
    void ShowMessage(string message);
    void Exit();

    void PromptToCreateRecipe();

    void ReadIngredientsFromUser();
    void Write(string filePath, List<Recipe> allRecipes);
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
}