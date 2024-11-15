using System.Data;
using SortingAlgorithmsAnalyzer.Models;

namespace SortingAlgorithmsAnalyzer.Mappers;

public class StudentMapper
{
    public static StudentModel MapToMovieModel(IDataRecord record)
    {
        return new StudentModel
        {
            Id = record.GetInt32(0),
            Gender = record.GetString(1),
            RaceEthnicity = record.GetString(2),
            ParentalLevelOfEducation = record.GetString(3),
            Lunch = record.GetString(4),
            TestPreparationCourse = record.GetString(5),
            MathScore = record.GetInt32(6),
            ReadingScore = record.GetInt32(7),
            WritingScore = record.GetInt32(8)
        };
    }
}