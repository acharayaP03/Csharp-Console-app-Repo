using RecipeApp.Recipes.Ingredients;

namespace RecipeApp.Repositories;

public class IngredientsRegister : IIngredientsRegister
{

    //public IEnumerable<Ingredient> All { get; } = new List<Ingredient>
    //{
    //    new WheatFlour(),
    //    new SpeltFlour(),
    //    new Butter(),
    //    new Chocolate(),
    //    new Sugar(),
    //    new Cardamom(),
    //    new Cinnamon(),
    //    new CocoaPowder()
    //};

    // new way of list
    public IEnumerable<Ingredient> All { get; } = [
        new WheatFlour(),
        new SpeltFlour(),
        new Butter(),
        new Chocolate(),
        new Sugar(),
        new Cardamom(),
        new Cinnamon(),
        new CocoaPowder()
    ];

    public Ingredient GetById(int id)
    {
        foreach (var ingredient in All)
        {
            if (ingredient.Id == id)
            {
                return ingredient;
            }
        }

        return null;
    }
}
