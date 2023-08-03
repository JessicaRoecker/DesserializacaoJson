namespace DesserializacaoJson.Models
{
    public interface IMetrics
    {
        List<Metric> MetricsMetrics { get; set; }
        string OrgId { get; set; }
    }
}