using FileContentParser.Model;

namespace FileContentParser.DataAccess;

public interface IFileDeserializer
{
    IEnumerable<FileContents> DeserializeFileContents(string? fileName, string contents);
}