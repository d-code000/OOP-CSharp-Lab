using System.Collections;

namespace OOP_CSharp_Lab2;

public class MagazineEnumerator(Magazine magazine) : IEnumerator
{
    // https://learn.microsoft.com/ru-ru/dotnet/api/system.collections.ienumerator?view=net-8.0
    private int _position = -1;

    object IEnumerator.Current => Current;

    public Article Current => (Article)magazine.Article[_position];

    public bool MoveNext()
    {
        while (_position < magazine.Article.Count - 1)
        {
            _position++;
            if (!magazine.Editor.Contains(((Article)magazine.Article[_position]).Author))
            {
                return true;
            }
        }

        return false;
    }

    public void Reset()
    {
        _position = -1;
    }
}