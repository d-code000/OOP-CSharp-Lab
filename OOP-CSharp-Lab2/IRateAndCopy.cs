namespace OOP_CSharp_Lab2;

// https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/types/interfaces
public interface IRateAndCopy // ? добавить IRateAndCopy<T>
{
    double Rating { get; }
    object DeepCopy(); // и сделать T DeepCopy()
}