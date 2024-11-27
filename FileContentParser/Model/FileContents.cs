namespace FileContentParser.Model;

public class FileContents
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public decimal Rating { get; set; }

    public override string ToString()
    {
        return $"Title: {Title}, Released year: {ReleaseYear}, Rating: {Rating}";
    }
}