namespace OOP_CSharp_Test;

[TestClass]
public class GetArticleArrayTest: ArticleArrayHelper
{
    public TestContext TestContext { get; }
    
    [TestInitialize]
    public void Init()
    {
        Assert.AreEqual(Size, SizeHeight * SizeWidth, "Size = SizeHeight * SizeWidth");
        
        AddArray();
        AddRectangularArray();
        AddJaggedArray();
        
        Stopwatch.Start();
    }
    
    [TestMethod]
    public void GetArrayTest()
    {
        for (int i = 0; i < Size; i++)
        {
            var author = Array[i].Author;
            var name = Array[i].Name;
            var rating = Array[i].Rating;
        }
    }
    
    [TestMethod]
    public void GetRectangularArrayTest()
    {
        for (int i = 0; i < SizeHeight; i++)
        for (int j = 0; j < SizeWidth; j++)
        {
            var author = RectangularArray[i, j].Author;
            var name = RectangularArray[i, j].Name;
            var rating = RectangularArray[i, j].Rating;
        }
    }
    
    [TestMethod]
    public void GetJaggedArrayTest()
    {
        for (int i = 0; i < SizeHeight; i++)
        for (int j = 0; j < SizeWidth; j++)
        {
            var author = JaggedArray[i][j].Author;
            var name = JaggedArray[i][j].Name;
            var rating = JaggedArray[i][j].Rating;
        }
    }
    
    [TestCleanup]
    public void GetTime()
    {
        Stopwatch.Stop();
        TestContext.WriteLine($"Time of test: {Stopwatch.ElapsedMilliseconds}");
    }
}