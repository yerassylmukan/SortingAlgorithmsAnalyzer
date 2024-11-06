using System.Data;
using SortingAlgorithmAnalyzer.Models;

namespace SortingAlgorithmAnalyzer.Mappers;

public static class WineMapper
{
    public static WineModel MapToWineModel(IDataRecord record)
    {
        return new WineModel
        {
            Type = record.GetString(0),
            FixedAcidity = record.GetFloat(1),
            VolatileAcidity = record.GetFloat(2),
            CitricAcid = record.GetFloat(3),
            ResidualSugar = record.GetFloat(4),
            Chlorides = record.GetFloat(5),
            FreeSulfurDioxide = record.GetInt32(6),
            TotalSulfurDioxide = record.GetInt32(7),
            Density = record.GetFloat(8),
            pH = record.GetFloat(9),
            Sulphates = record.GetFloat(10),
            Alcohol = record.GetFloat(11),
            Quality = record.GetInt32(12)
        };
    }
}