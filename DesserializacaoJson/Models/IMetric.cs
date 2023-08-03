namespace DesserializacaoJson.Models
{
    public interface IMetric
    {
        string Name { get; set; }
        List<ValueTrend> ValueTrend { get; set; }
    }
}