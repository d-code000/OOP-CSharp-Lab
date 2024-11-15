using System.Text;

namespace Pr_Pr_2;

public class TestClass
{
    private List<int> _ints = new List<int>();
    private enum State
    {
        Positive, Negative, Natural, Unset
    }

    private State _state;

    public TestClass()
    {
        _ints.Add(1);
        _ints.Add(2);
        _ints.Add(3);
        _ints.Add(4);
        _ints.Add(5);
    }

    public List<int> Ints
    {
        get
        {
            return new List<int>(_ints);
        } 
        private set => _ints = value;
    }

    public int this[int x]
    {
        get => _ints[x];
        set
        {
            if (x >= _ints.Count )
            {
                for (int i = _ints.Count; i < x; i++) _ints.Add(0);
                _ints.Add(value);
            }
            else
            {
                _ints[x] = value;
            }
        }
    }

    public string ListToString()
    {
        var sb = new StringBuilder();
        foreach (var x in _ints)
        {
            sb.Append(x);
            sb.Append(' ');
        }
        return sb.ToString();
    }

    public override string ToString()
    {
        return $"{_state}: {ListToString()}";
    }

    public void AddElem(int list)
    {
        _ints.Add(list);
    }

    public void AddElems(List<int> list)
    {
        _ints.AddRange(list);
    }
    
    public void AddElems(params int[] list)
    {
        _ints.AddRange(list);
    }
}