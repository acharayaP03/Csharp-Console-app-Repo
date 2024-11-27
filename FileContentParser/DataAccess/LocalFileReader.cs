namespace FileContentParser.DataAccess;

public class LocalFileReader : ILocalFileReader
{
    public string Read(string fileName)
    {
        return File.ReadAllText(fileName);
    }
}