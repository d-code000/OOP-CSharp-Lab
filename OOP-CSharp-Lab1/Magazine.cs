namespace OOP_CSharp_Lab;

public class Magazine
{
    private string _name { get; set; }
    private Frequency _frequency { get; set; }
    private DateTime _releaseDate { get; set; }
    private int _curculation { get; set; }
    // m.b. change type of list
    private List<Article> _listArticle { get; set; }

    public Magazine(string name, Frequency frequency, DateTime releaseDate, int curculation)
    {
        _name = name;
        this._frequency = frequency;
        _releaseDate = releaseDate;
        _curculation = curculation;
        _listArticle = new List<Article>();
    }

    public Magazine()
    {
        _name = "Name";
        this._frequency = Frequency.Weekly;
        _releaseDate = DateTime.Now;
        _curculation = 0;
        _listArticle = new List<Article>();
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Frequency Frequency
    {
        get { return _frequency; }
        set { _frequency = value; }
    }

    public DateTime ReleaseDate
    {
        get { return _releaseDate; }
        set { _releaseDate = value; }
    }

    public int Curculation
    {
        get { return _curculation; }
        set { _curculation = value; }
    }

    public List<Article> ListArticle
    {
        get { return _listArticle; }
        set { _listArticle = value; }
    }

    public double MiddleRating
    {
        get
        {
            List<double> ratings = _listArticle.Select(x => x.Rating).ToList();
            return (Enumerable.Sum(ratings) / ratings.Count);
        }
    }
    
    
    
    
}