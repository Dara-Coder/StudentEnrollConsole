using System.Text.Json;
using System.Text.Json.Serialization;

namespace Student_Enroll_Console.Model
{
    public class TimeSpanConverter : JsonConverter<TimeSpan>
    {
        public override TimeSpan Read(ref Utf8JsonReader reader,Type typeToConvert,JsonSerializerOptions options)
        {
            if(reader.TokenType == JsonTokenType.String)
            {
                return TimeSpan.Parse(reader.GetString());
            }
            return TimeSpan.Zero;
        }

        public override void Write(Utf8JsonWriter writer,TimeSpan value,JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(@"hh\:mm"));
        }
    }
    public class Section
    {
        public int id { get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
        [JsonConverter(typeof(TimeSpanConverter))]
        public TimeSpan checkin_time { get; set; }
        [JsonConverter(typeof(TimeSpanConverter))]
        public TimeSpan checkout_time { get; set; }
    }
}