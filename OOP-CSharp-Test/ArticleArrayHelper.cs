using OOP_CSharp_Lab;

namespace OOP_CSharp_Test;

public class ArticleArrayHelper
{
    protected const int Size = 21470000; // Общее количество элементов
    protected const int SizeHeight = 2147;
    protected const int SizeWidth = 10000;
    protected Article[] Array = new Article[Size];
    protected Article[,] RectangularArray = new Article[SizeHeight, SizeWidth];
    protected Article[][] JaggedArray = new Article[SizeHeight][];
    protected Random Random = new Random();
    
    
    protected void AddArray()
    {
        for (int i = 0; i < Size; i++)
        {
            Array[i] = new Article(
                new Person($"FirstName{i}", $"LastName{i}", DateTime.FromBinary(i)),
                name: $"Article {i}",
                rating: Random.NextDouble() * 10
            );
        }
    }
    
    protected void AddRectangularArray()
    {
        for (int i = 0; i < SizeHeight; i++)
        {
            for (int j = 0; j < SizeWidth; j++)
            {
                RectangularArray[i, j] = new Article(
                    new Person($"FirstName{i}{j}", $"LastName{i}{j}", DateTime.FromBinary(i + j)),
                    name: $"Article {i}{j}",
                    rating: Random.NextDouble() * 10
                );
            }
        }
    }
    
    protected void AddJaggedArray()
    {
        for (int i = 0; i < SizeHeight; i++)
        {
            JaggedArray[i] = new Article[SizeWidth];
            for (int j = 0; j < SizeWidth; j++)
            {
                JaggedArray[i][j] = new Article(
                    new Person($"FirstName{i}{j}", $"LastName{i}{j}", DateTime.FromBinary(i + j)),
                    name: $"Article {i}{j}",
                    rating: Random.NextDouble() * 10
                );
            }
        }
    }
}