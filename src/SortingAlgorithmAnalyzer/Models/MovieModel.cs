namespace SortingAlgorithmAnalyzer.Models;

public class MovieModel
{
    public int Id { get; set; }
    public string OriginalLanguage { get; set; }
    public string OriginalTitle { get; set; }
    public string Overview { get; set; }
    public float Popularity { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Title { get; set; }
    public float VoteAverage { get; set; }
    public int VoteCount { get; set; }
}