using ENS.WebApi.Channels;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ENS.WebApi
{
    public sealed class EmailConverter : JsonConverter<Email>
    {
        public EmailConverter()
        {

        }

        public override Email Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var email = reader.GetString();

            return new Email(email);
        }

        public override void Write(Utf8JsonWriter writer, Email value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value}");
        }
    }
}
