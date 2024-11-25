
namespace C__Console_Apps.ExceptionHendeling;

public class ExplicitClassException
{
    public string Name { get; set; }

    public int YearOfBirth { get; set; }


    public ExplicitClassException(string name, int yearOfBirth)
    {
        if (name == string.Empty)
        {
            throw new Exception("Invalid name provided");
        }

        if (yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
        {
            throw new Exception("Invalid date of birth provided");
        }

        Name = name;
        YearOfBirth = yearOfBirth;
    }
}
