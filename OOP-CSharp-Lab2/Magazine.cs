using System.Collections;

namespace OOP_CSharp_Lab2;

public class Magazine: Edition, IRateAndCopy
{
    private OOP_CSharp_Lab1.Frequency _period;
    private ArrayList _editor;
    private ArrayList _article;
    public double Rating { get; }

    public Magazine(string name,  OOP_CSharp_Lab1.Frequency period, DateTime releaseDate, int circulation, double rating)
        : base(name, releaseDate, circulation)
    {
        _period = period;
        _editor = new ArrayList();
        _article = new ArrayList();
        if (rating < 0) Rating = 0;
        else if (rating > 10) Rating = 10;
        else Rating = rating;
    }

    public Magazine() : base()
    {
        _period = OOP_CSharp_Lab1.Frequency.Weekly;
        _editor = new ArrayList();
        _article = new ArrayList();
        Rating = 0;
    }
    
    public double AverageRating
    {
        get
        {
            List<double> ratings = new List<double>();
            foreach (Article article in _article)
            {
                ratings.Add(article.Rating);
            }
            return (ratings.Sum() / ratings.Count);
        }
    }

    public ArrayList Article
    {
        get => _article; 
        set => _article = value;
    }

    public ArrayList Editor
    {
        get => _editor; 
        set => _editor = value;
    }

    public OOP_CSharp_Lab1.Frequency Frequency
    {
        get => _period;
        set => _period = value;
    }

    public void AddArticles(params Article[] articles)
    {
        Article.AddRange(articles);
    }

    public void AddEditors(params Person[] editors)
    {
        Editor.AddRange(editors);
    }

    public override string ToString()
    {
        var redactorString = "";
        var articleString = "";
        foreach (Person redactor in _editor)
        {
            redactorString += redactor + "; ";
        }

        foreach (var article in _article)
        {
            articleString += article + "; ";
        }

        return $"{ToShortString()}\n" +
               $"Redactors: {redactorString}\n" +
               $"Articles: {articleString}\n";
    }

    public virtual string ToShortString()
    {
        return $"{base.ToString()}\n" +
               $"Average rating: {AverageRating:F2}\n" +
               $"Period: {_period}\n" +
               $"Rating: {Rating}\n";
    }

    public new virtual object DeepCopy()
    {
        var copy = new Magazine(NameProperty, _period, ReleaseDateProperty, CirculationProperty, Rating);
        var editorList = new ArrayList();
        var articleList = new ArrayList();
        foreach (Person editor in _editor)
        {
            editorList.Add(editor.DeepCopy());
        }

        foreach (Article article in _article)
        {
            articleList.Add(article.DeepCopy());
        }

        copy.Editor = editorList;
        copy.Article = articleList;

        return copy;
    }

    public Edition Edition
    {
        get => base.DeepCopy();
        set
        {
            NameProperty = value.NameProperty;
            ReleaseDateProperty = value.ReleaseDateProperty;
            CirculationProperty = value.CirculationProperty;
        }
    }

    public ArrayList this[double border]
    {
        get
        {
            var newArticle = new ArrayList();
            foreach (Article article in _article)
            {
                if (article.Rating >= border)
                {
                    newArticle.Add(article);
                }
            }
            return newArticle;
        }
    }

    public ArrayList this[string name]
    {
        get
        {
            var newArticle = new ArrayList();
            foreach (Article article in _article)
            {
                if (article.Name.Contains(name))
                {
                    newArticle.Add(article);
                }
            }
            return newArticle;
        }
    }
}