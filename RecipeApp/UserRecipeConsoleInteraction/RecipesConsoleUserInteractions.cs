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
}