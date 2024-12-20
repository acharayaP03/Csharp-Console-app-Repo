
using System.Collections;
using Newtonsoft.Json;


Console.WriteLine("Advanced Collections");

var customCollection = new CustomCollection(
        new string[] { "aaa", "bbb", "ccc"}
    );

var parameterLessCustomCollection = new CustomCollection
{
    "aaa", "bbb", "cccc"
};

var json = JsonConvert.SerializeObject(customCollection);

Console.WriteLine(json);


// under the hood this is how the foreach loop works
//IEnumerator wordsDefaultEnumerator = customCollection.GetEnumerator();
//object currentWord;

//while ( wordsDefaultEnumerator.MoveNext() )
//{
//    currentWord = wordsDefaultEnumerator.Current;
//    Console.WriteLine(currentWord);
//}



// this will not work since the CustomCollection class is not a type of IEnumerable
foreach ( var item in customCollection )
{
    Console.WriteLine( item );
}


var ints = new int[] { 1, 2, 3, 4, 5 };
var strings = new string[] { "aaa", "bb", "cccc" };

var pairOfArrays = new PairOfArrays<int, string>(ints, strings);
(int, string) results = pairOfArrays[2, 1]; // getter
pairOfArrays[1, 2] = (100, "kkk");

Console.WriteLine(results);


Console.ReadKey();

public class CustomCollection : IEnumerable<string>
{
    public string[] Words { get; }

    private int _currentIndex = 0;

    // if we need to initialize custom collection as a parameter less then we must have parameter less constructor 
    // and a add method

    public CustomCollection()
    {
        Words = new string[10];
    }

    public CustomCollection(string[] words)
    {
        Words = words;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<string> GetEnumerator()
    {
        //return new WordsEnumerator(Words);
        //foreach(var word in Words)
        //{
        //    yield return word;
        //}

        // or 
        IEnumerable<string> words = Words;
        return words.GetEnumerator();
    }

    public string this[int index]
    {
        get => Words[index];
        set => Words[index] = value;
    }

    public void Add(string item)
    {
        Words[_currentIndex] = item;
        ++_currentIndex;
    }
}

public class WordsEnumerator : IEnumerator<string>
{
    private const int initialPosition = -1;
    private int _currentPosition = initialPosition;
    private readonly string[] _words;

    public WordsEnumerator(string[] words)
    {
        _words = words;
    }

    object IEnumerator.Current => Current;

    public string Current
    {
        get 
        {
            try
            {
                return _words[_currentPosition]; 
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new IndexOutOfRangeException(
                    $"{nameof(CustomCollection)}'s end reached.", ex
                );
            }
        }
    }

    public bool MoveNext()
    {
        ++_currentPosition;
        return _currentPosition < _words.Length;
    }

    public void Reset()
    {
        _currentPosition = initialPosition;
    }

    public void Dispose()
    {
        
    }
}


public class PairOfArrays<TLeft, TRight> 
{
    private readonly TLeft[] _left;
    private readonly TRight[] _right;

    public PairOfArrays(
        TLeft[] left, TRight[] right)
    {
        _left = left;
        _right = right;
    }

    public (TLeft Left, TRight Right) this[int leftIndex, int rightIndex]
    {
        get
        {

            return (_left[leftIndex], _right[rightIndex]);
        }
        set
        {
            _left[leftIndex] = value.Left;
            _right[rightIndex] = value.Right;
        }
    }


}