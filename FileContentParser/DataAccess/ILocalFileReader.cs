namespace FileContentParser.DataAccess;

public interface ILocalFileReader
{
    string Read(string fileName);
}