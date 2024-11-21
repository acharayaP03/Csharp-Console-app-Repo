

using RecipeApp;
using RecipeApp.Recipes;
using RecipeApp.Recipes.Ingredients;
using RecipeApp.UserRecipeConsoleInteraction;


RecipesConsoleUserInteractions.PrintApplicationStartingLabel();

CookBookRecipes cookBookRecipes = new(
        new RecipesRepository(),
        new RecipesConsoleUserInteractions(
                new IngredientsRegister()
            )
    );
cookBookRecipes.Run("recipe.txt");


public interface IRecipesRepository
{
       List<Recipe> Read(string filePath);

}

public class RecipesRepository: IRecipesRepository
{

    public List<Recipe> Read(string filePath)
    {
        return new List<Recipe>
        {
            new Recipe( new List<Ingredient>
            {
                new WheatFlour(),new Butter(),new Sugar()
            }),
            new Recipe(new List<Ingredient>
            {
                new CocoaPowder(), new SpeltFlour(),new Cinnamon()
            })
        };
    }
}
