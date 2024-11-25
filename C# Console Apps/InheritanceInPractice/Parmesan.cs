namespace C__Console_Apps.InheritanceInPractice;

public class Parmesan : Ingredients
{
    public Parmesan(int extraToppingPrice) : base(extraToppingPrice)
    {
    }

    public override string Name { get; } = "Parmesan Cheese";

    public override void Prepare()
        => Console.WriteLine($"Preparing {Name}");
}