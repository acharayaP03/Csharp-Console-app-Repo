
// On below case, where we are reading or writing from or to file, we must have dispose method
// to free up memory. because in this case the garbage collector will not call it clean up. 
// we must manage ourself

/**
 * 
 * 
 * to make sure the dispose method is called we must user 'using statement'
 * using (var filereader = new AllLinesFromTextFileReader())
 * {    
 *      .... 
 * }
 * 
 * or 
 * 
 * using var reader = new AllLinesFromTextFileReader(filePath)
 */

public class AllLinesFromTextFileReader : IDisposable
{
    private readonly StreamReader _streamReader;

    public AllLinesFromTextFileReader(string filePath)
    {
        _streamReader = new StreamReader(filePath);
    }

    public List<string> ReadAllLines()
    {
        var result = new List<string>();
        while (!_streamReader.EndOfStream)
        {
            result.Add(_streamReader.ReadLine());
        }

        return result;
    }

    public void Dispose()
    {
        _streamReader.Dispose();
    }
}