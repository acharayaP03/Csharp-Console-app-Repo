

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("************* Welcome to RecipeApp *************");
Console.WriteLine("************* Create your recipe and save it *************");

var recipeApp = new RecipeApp();
recipeApp.Run();


Console.WriteLine("Enter the recipe name: ");

Console.ReadKey();

public class RecipeApp
{
    private readonly RecipesRepository _recipesRepository;

    private readonly RecipesUserInteractions _recipesUserInteractions;
    public RecipeApp(RecipesRepository recipesRepository, RecipesUserInteractions recipesUserInteractions)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteractions = recipesUserInteractions;
    }



    public void Run()
    {
        string filePath = "recipes.txt";
        var allRecipes = _recipesRepository.GetAllRecipes(filePath);

        _recipesUserInteractions.PromptToCreateRecipe();

        var ingredients = _recipesUserInteractions.ReadIngredientsFromUser();

        if(ingredients.Count > 0)
        {
            Recipe recipies = new (ingredients);
        }
        else
        {
            _recipesUserInteractions.ShowMessage("No ingredients have been selected" 
                + "Recipe will not be saved");
        }
    }
}

internal class Recipe
{
    private object ingredients;

    public Recipe(object ingredients)
    {
        this.ingredients = ingredients;
    }
}

public class RecipesRepository
{

    public string GetAllRecipes(string filePath)
    {
        return "first recipe";;
    }
}

public class RecipesUserInteractions
{
    internal void PromptToCreateRecipe()
    {
        throw new NotImplementedException();
    }

    internal object ReadIngredientsFromUser()
    {
        throw new NotImplementedException();
    }

    internal void ShowMessage(string v)
    {
        throw new NotImplementedException();
    }
}