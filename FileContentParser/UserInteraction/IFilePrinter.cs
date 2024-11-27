using FileContentParser.Model;

namespace FileContentParser.UserInteraction;

public interface IFilePrinter
{
    void Print(IEnumerable<FileContents> formatedContents);
}