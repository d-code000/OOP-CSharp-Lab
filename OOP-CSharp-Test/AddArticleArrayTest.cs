using System.Diagnostics;
using OOP_CSharp_Lab1;

namespace OOP_CSharp_Test;

[TestClass]
public class AddArticleArrayTest: ArticleArrayHelper
{
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
        AddArray();
    }
    
    [TestMethod]
    public void AddRectangularArrayTest()
    {
        AddRectangularArray();
    }
    
    [TestMethod]
    public void AddJaggedArrayTest()
    {
        AddJaggedArray();
    }

    [TestCleanup]
    public void GetTime()
    {
        _stopwatch.Stop();
        Console.WriteLine($"Time of test: {_stopwatch.ElapsedMilliseconds}");
    }
}