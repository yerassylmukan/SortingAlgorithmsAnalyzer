using System.Data;
using Npgsql;

namespace SortingAlgorithmsAnalyzer;

public class DatabaseService
{
    private readonly string _connectionString = "Host=localhost;Username=postgres;Password=secret1234;Database=Dataset";

    public async Task<List<T>> GetModelsAsync<T>(string query, Func<IDataRecord, T> map)
    {
        var results = new List<T>();

        using (var connection = new NpgsqlConnection(_connectionString))
        {
            await connection.OpenAsync();

            using (var command = new NpgsqlCommand(query, connection))
            using (var reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    results.Add(map(reader));
                }
            }
        }

        return results;
    }
}