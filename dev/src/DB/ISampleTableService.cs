using src.DB;

public interface ISampleTableService
{
    Task<IEnumerable<SampleTable>> GetSamplesAsync();
    SampleTable CreateSample(SampleTable sampleTable);
}