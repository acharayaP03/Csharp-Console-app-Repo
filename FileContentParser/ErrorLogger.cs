namespace FileContentParser;

public class ErrorLogger
{
    private readonly string _logFileName;

    public ErrorLogger(string logFileName)
    {
        _logFileName = logFileName;
    }


    public void Log(Exception ex)
    {

        var fileEntry =
$@"[{DateTime.Now}]
Exception message: {ex.Message}
Stack trace: {ex.StackTrace}


";
        File.AppendAllText(_logFileName, fileEntry);
    }
}