
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;

namespace DesserializacaoJson.Models;




    public partial class RootObject
{
        [JsonPropertyName("OrgId")]
        public string OrgId { get; set; }

        [JsonPropertyName("metrics")]
        public List<Metric> Metrics { get; set; }
    }

    public partial class Metric
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("valueTrend")]
        public List<ValueTrend> ValueTrend { get; set; }
    }

    public partial class ValueTrend
    {
        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; set; }

        [JsonPropertyName("val")]
        public string Val { get; set; }
    }


