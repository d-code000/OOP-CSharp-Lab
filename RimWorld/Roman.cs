namespace RimWorld;

public class Roman
{
    private const int _maxRange = 3999;
    private static Dictionary<string, int> _supportSym = new Dictionary<string, int>
    {
        {"I", 1},
        {"V", 5},
        {"X", 10},
        {"L", 50},
        {"C", 100},
        {"D", 500},
        {"M", 1000},
    };
    private int _num;
    
    public int Num
    {
        get => _num;
        set
        {
            if (Math.Abs(value) > _maxRange) 
                throw new ArgumentOutOfRangeException($"Support range: abs(num) < {_maxRange}");
            _num = value;
        }
    }
    
    public Roman(string romanNum)
    {
        var max = 0;
        for (int i = romanNum.Length; i >= 0; i++)
        {
            var nowDecSym = _supportSym[romanNum[i]];
            if (nowDecSym < max)
            {
                Num -= nowDecSym;
            }
            else Num += nowDecSym;
        }
    }

    public Roman(int decNum)
    {
        Num = decNum;
    }

    public Roman() {}

    public static Roman operator +(Roman obj1, Roman obj2)
    {
        return new Roman(obj1.Num + obj2.Num);
    }
}