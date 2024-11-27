using FileContentParser.Model;

namespace FileContentParser.UserInteraction;

public interface IFilePrinter
{
    void Print(List<FileContents> formatedContents);
}