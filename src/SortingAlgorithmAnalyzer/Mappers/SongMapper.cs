using System.Data;
using SortingAlgorithmAnalyzer.Models;

namespace SortingAlgorithmAnalyzer.Mappers;

public class SongMapper
{
    public static SongModel MapToSongModel(IDataRecord record)
    {
        return new SongModel
        {
            Title = record.GetString(0),
            Artist = record.GetString(1),
            Album = record.GetString(2),
            Genre = record.GetString(3),
            ReleaseDate = record.GetDateTime(4),
            Duration = record.GetInt32(5),
            Popularity = record.GetInt32(6)
        };
    }
}