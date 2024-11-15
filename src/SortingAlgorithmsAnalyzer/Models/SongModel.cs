namespace SortingAlgorithmsAnalyzer.Models;

public class SongModel
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }
    public string Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Duration { get; set; }
    public int Popularity { get; set; }
}