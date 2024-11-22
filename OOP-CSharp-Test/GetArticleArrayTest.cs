using System.Diagnostics;

namespace OOP_CSharp_Test;

[TestClass]
public class GetArticleArrayTest: ArticleArrayHelper
{
    private const int LongTest = 100;
    private Stopwatch _stopwatch = new Stopwatch();
    
    [TestInitialize]
    public void Init()
    {
        Assert.AreEqual(Size, SizeHeight * SizeWidth, "Size = SizeHeight * SizeWidth");
    }
    
    [TestMethod]
    public void GetArrayTest()
    {
        AddArray();
        _stopwatch.Start();
        for (int none = 0; none < LongTest; none++)
        {
            for (int i = 0; i < Size; i++)
            {
                var author = Array[i].Author;
                var name = Array[i].Name;
                var rating = Array[i].Rating;
            }
        }
    }
    
    [TestMethod]
    public void GetRectangularArrayTest()
    {
        AddRectangularArray();
        _stopwatch.Start();
        for (int none = 0; none < LongTest; none++)
        {
            for (int i = 0; i < SizeHeight; i++)
            for (int j = 0; j < SizeWidth; j++)
            {
                var author = RectangularArray[i, j].Author;
                var name = RectangularArray[i, j].Name;
                var rating = RectangularArray[i, j].Rating;
            }
        }
    }
    
    [TestMethod]
    public void GetJaggedArrayTest()
    {
        AddJaggedArray();
        _stopwatch.Start();
        for (int none = 0; none < LongTest; none++)
        {
            for (int i = 0; i < SizeHeight; i++)
            for (int j = 0; j < SizeWidth; j++)
            {
                var author = JaggedArray[i][j].Author;
                var name = JaggedArray[i][j].Name;
                var rating = JaggedArray[i][j].Rating;
            }
        }
    }
    
    [TestCleanup]
    public void GetTime()
    {
        _stopwatch.Stop();
        Console.WriteLine($"Time of test: {_stopwatch.ElapsedMilliseconds}");
    }
}