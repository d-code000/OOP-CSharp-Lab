using OOP_CSharp_Lab;

namespace OOP_CSharp_Test;

[TestClass]
public class AddArticleArrayTest: ArticleArrayHelper
{
    public TestContext TestContext { get; }
    
    [TestInitialize]
    public void Init()
    {
        Assert.AreEqual(Size, SizeHeight * SizeWidth, "Size = SizeHeight * SizeWidth");
        Stopwatch.Start();
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
        Stopwatch.Stop();
        TestContext.WriteLine($"Time of test: {Stopwatch.ElapsedMilliseconds}");
    }
}