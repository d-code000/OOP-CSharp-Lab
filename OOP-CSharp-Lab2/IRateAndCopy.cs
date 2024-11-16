namespace OOP_CSharp_Lab2;

public interface IRateAndCopy
{
    double Rating { get; }
    object DeepCopy();
}