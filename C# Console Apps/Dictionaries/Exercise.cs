using C__Console_Apps.Linqs;

public static class Exercise
{
    public static Dictionary<PetType, double> FindMaxWeights(List<Pet> pets)
    {
        var result = new Dictionary<PetType, double>();

        foreach (var pet in pets)
        {
            if (result.ContainsKey(pet.PetType) || pet.Weight > result[pet.PetType])
            {
                result[pet.PetType] = pet.Weight;
            }
        }

        return result;
    }
}
