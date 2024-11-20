using RecipeApp.Recipes;

namespace RecipeApp.UserRecipeConsoleInteraction;

public class RecipesConsoleUserInteractions : IRecipesUserInteractions
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    public void Exit()
    {
        Console.WriteLine("Press any key to exit application.");
        Console.ReadKey();
    }

    public void PromptToCreateRecipe()
    {
        throw new NotImplementedException();
    }

    public void ReadIngredientsFromUser()
    {
        throw new NotImplementedException();
    }

    public void Write(string filePath, List<Recipe> allRecipes)
    {
        throw new NotImplementedException();
    }

    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Count() > 0)
        {
            Console.WriteLine("Existing recipes are:" + Environment.NewLine);

            var counter = 1;
            foreach (var recipe in allRecipes)
            {
                Console.WriteLine($"************{counter}************");
                Console.WriteLine(recipe);
                Console.WriteLine();
                ++counter;
            }
        }
    }
}