using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DesserializacaoJson.Models;

[ApiController]
[Route("api/[controller]")]
    public class MetricsController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<RootObject>> GetMetrics()
        {
            string jsonFilePath = @"C:\Users\Acer\Downloads\json.json";

            using (StreamReader reader = new StreamReader(jsonFilePath))
            {
                string jsonString = await reader.ReadToEndAsync();
            RootObject metrics = JsonConvert.DeserializeObject<RootObject>(jsonString);

                if (metrics != null && metrics.Metrics != null)
                {
                    foreach (var metric in metrics.Metrics)
                    {
                        if (metric != null && metric.ValueTrend != null)
                        {
                            foreach (var trend in metric.ValueTrend)
                            {
                                if (trend != null)
                                {
                              
                                }
                            }
                        }
                    }
                }

                return Ok(metrics);
            }
        }
    }










