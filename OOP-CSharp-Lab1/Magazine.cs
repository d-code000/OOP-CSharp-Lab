namespace OOP_CSharp_Lab;

public class Magazine
{
    private string _name;
    private Frequency _frequency;
    private DateTime _releaseDate;

    private int _circulation;
    // m.b. change type of list
    private List<Article> _listArticle;

    public Magazine(string name, Frequency frequency, DateTime releaseDate, int circulation)
    {
        _name = name;
        _frequency = frequency;
        _releaseDate = releaseDate;
        _circulation = circulation;
        _listArticle = new List<Article>();
    }

    public Magazine()
    {
        _name = "Name";
        _frequency = Frequency.Weekly;
        _releaseDate = DateTime.Now;
        _circulation = 0;
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

    public int Circulation
    {
        get { return _circulation; }
        set { _circulation = value; }
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

    public bool this[Frequency frequency]
    {
        get { return _frequency == frequency; }
    }

    public void AddArticles(params Article[] articles)
    {
        foreach (var article in articles)
        {
            _listArticle.Add(article);
        }
    }

    public override string ToString()
    {
        string articles = _listArticle.Count > 0 ? string.Join(Environment.NewLine + "\t", _listArticle) : "No articles";
        return $"Name: {_name} \n" +
               $"Frequency: {_frequency} \n" +
               $"Release date: {_releaseDate} \n" +
               $"Circulation: {_circulation} \n" +
               $"List of articles:\n\t{articles}";
    }

    public string ToShortString()
    {
        return $"Name: {_name}, " +
               $"Frequency: {_frequency}, " +
               $"Release date: {_releaseDate}, " +
               $"Circulation: {_circulation}, " +
               $"Middle rating: {MiddleRating}";
    }
}