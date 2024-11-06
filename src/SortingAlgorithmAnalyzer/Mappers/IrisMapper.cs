using System.Data;
using SortingAlgorithmAnalyzer.Models;

namespace SortingAlgorithmAnalyzer.Mappers;

public static class IrisMapper
{
    public static IrisModel MapToIrisModel(IDataRecord record)
    {
        return new IrisModel
        {
            Id = record.GetInt32(0),
            SepalLengthCm = record.GetFloat(1),
            SepalWidthCm = record.GetFloat(2),
            PetalLengthCm = record.GetFloat(3),
            PetalWidthCm = record.GetFloat(4),
            Species = record.GetString(5)
        };
    }
}