using System.Data;
using Dapper;
using src.DB;

public class SampleTableService : ISampleTableService
{
    private IDbConnection _connection;

    public SampleTableService(IDbConnection connection)
    {
        _connection = connection;
    }

    public Task<IEnumerable<SampleTable>> GetSamplesAsync()
    {
        return Task.FromResult(_connection.Query<SampleTable>("SELECT * FROM sample_table ORDER BY id"));
    }

    public SampleTable CreateSample(SampleTable sampleTable)
    {
        var sql = $@"INSERT INTO sample_table(name, description) VALUES(@{nameof(sampleTable.Name)}, @{nameof(sampleTable.Description)}) RETURNING id";
        var id = _connection.Query<int>(sql, sampleTable).Single();
        sampleTable.Id = id;
        return sampleTable;
    }
}