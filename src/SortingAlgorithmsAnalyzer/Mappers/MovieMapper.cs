using System.Data;
using SortingAlgorithmsAnalyzer.Models;

namespace SortingAlgorithmsAnalyzer.Mappers;

public static class MovieMapper
{
    public static MovieModel MapToMovieModel(IDataRecord record)
    {
        return new MovieModel
        {
            Id = record.GetInt32(0),
            OriginalLanguage = record.GetString(1),
            OriginalTitle = record.GetString(2),
            Overview = record.GetString(3),
            Popularity = record.GetFloat(4),
            ReleaseDate = record.GetDateTime(5),
            Title = record.GetString(6),
            VoteAverage = record.GetFloat(7),
            VoteCount = record.GetInt32(8)
        };
    }
}