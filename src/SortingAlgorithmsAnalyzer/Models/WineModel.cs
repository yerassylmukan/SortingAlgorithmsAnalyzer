namespace SortingAlgorithmsAnalyzer.Models;

public class WineModel
{
    public string Type { get; set; }
    public float FixedAcidity { get; set; }
    public float VolatileAcidity { get; set; }
    public float CitricAcid { get; set; }
    public float ResidualSugar { get; set; }
    public float Chlorides { get; set; }
    public int FreeSulfurDioxide { get; set; }
    public int TotalSulfurDioxide { get; set; }
    public float Density { get; set; }
    public float pH { get; set; }
    public float Sulphates { get; set; }
    public float Alcohol { get; set; }
    public int Quality { get; set; }
}