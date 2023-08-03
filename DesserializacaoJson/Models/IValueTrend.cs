namespace DesserializacaoJson.Models
{
    public interface IValueTrend
    {
        DateTimeOffset Date { get; set; }
        string Val { get; set; }
    }
}