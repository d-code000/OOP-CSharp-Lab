using System.Diagnostics;

namespace OOP_CSharp_Test;

[TestClass]
public class AddArticleArrayTest: ArticleArrayHelper
{
    private const int LongTest = 10;
    private Stopwatch _stopwatch = new Stopwatch();
    
    [TestInitialize]
    public void Init()
    {
        Assert.AreEqual(Size, SizeHeight * SizeWidth, "Size = SizeHeight * SizeWidth");
        _stopwatch.Start();
    }

    [TestMethod]
    public void AddArrayTest()
    {
        for (int none = 0; none < LongTest; none++)
        {
            AddArray();
        }
    }
    
    [TestMethod]
    public void AddRectangularArrayTest()
    {
        for (int none = 0; none < LongTest; none++)
        {
            AddRectangularArray();
        }
    }
    
    [TestMethod]
    public void AddJaggedArrayTest()
    {
        for (int none = 0; none < LongTest; none++)
        {
            AddJaggedArray();
        }
    }

    [TestCleanup]
    public void GetTime()
    {
        _stopwatch.Stop();
        Console.WriteLine($"Time of test: {_stopwatch.ElapsedMilliseconds}");
    }
}