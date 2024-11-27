using FileContentParser.Model;

namespace FileContentParser.DataAccess;

public interface IFileDeserializer
{
    List<FileContents> DeserializeFileContents(string? fileName, string contents);
}