using System.Text.Json.Serialization;

namespace zuri_week_1.DTO_s
{
    public class ResponseDto
    {
        public string SlackUsername { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public OperationType Operation_type { get; set; }
        public int Result { get; set; }
    }
}
