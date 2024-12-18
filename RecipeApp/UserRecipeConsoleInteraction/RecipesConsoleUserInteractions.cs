﻿using RecipeApp.Recipes;
using RecipeApp.Recipes.Ingredients;
using RecipeApp.Repositories;

namespace RecipeApp.UserRecipeConsoleInteraction;

public class RecipesConsoleUserInteractions : IRecipesConsoleUserInteractions
{

    private readonly IngredientsRegister _ingredientsRegister;

    public RecipesConsoleUserInteractions(IngredientsRegister ingredientsRegister)
    {
        _ingredientsRegister = ingredientsRegister;
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }


    public IEnumerable<Ingredient> ReadIngredientsFromUser()
    {

        bool shallStop = false;
        var ingredients = new List<Ingredient>();

        while (!shallStop)
        {
            Console.WriteLine("Add an ingredient by its ID," +
                "or type anything if you are done."
                );
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int id))
            {
                var selectedIngredient = _ingredientsRegister.GetById(id);
                if(selectedIngredient is not null)
                {
                    ingredients.Add(selectedIngredient);
                }
            }
            else 
            {
                shallStop = true;
            }
        }
        return ingredients;
    }

    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Count() > 0)
        {
            Console.WriteLine("Existing recipes are:" + Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.Cyan;

            allRecipes.Select((recipe, index) =>
                   $"************ {index + 1} ************" + Environment.NewLine + recipe +
                   Environment.NewLine
               )
                   .ToList()
                   .ForEach(Console.WriteLine);

            Console.ResetColor();
        }
    }

    public void PromptToCreateRecipe()
    {
        Console.WriteLine("Create a new Recipe!"
                + "Available ingredients are:"
            );

        foreach(var ingredient in _ingredientsRegister.All)
        {
            Console.WriteLine(ingredient);
        }
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to exit application.");
        Console.ReadKey();
    }

    public static void PrintApplicationStartingLabel()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("************* Welcome to RecipeApp *************");
        Console.WriteLine("************* Create your recipe and save it *************");

        Console.ResetColor();
    }


}
