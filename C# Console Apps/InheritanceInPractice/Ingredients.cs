namespace C__Console_Apps.InheritanceInPractice;

public abstract class Ingredients
{

    public int PriceIfExtraToppings { get; }
    public Ingredients(int extraToppingPrice)
    {
        PriceIfExtraToppings = extraToppingPrice;
    }

    public override string ToString() => Name;

    // virtual allows the derived class to override the property
    public virtual string Name { get; } = "Initial ingredients";

    public string Describe() => $"{Name} of the Recipe..";

    public abstract void Prepare();
}