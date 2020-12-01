using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sims.Application.OnlineForm
{
    internal class NullableDateTimeConverter : JsonConverter<DateTime?>
    {
        public override DateTime? Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (String.IsNullOrEmpty(reader.GetString()))
                return null;
            else
                return DateTime.Parse(reader.GetString(), CultureInfo.InvariantCulture);
        }


        public override void Write(
            Utf8JsonWriter writer,
            DateTime? dateTimeValue,
            JsonSerializerOptions options) =>
                writer.WriteStringValue(dateTimeValue.Value.ToUniversalTime().ToLongDateString());

    }
}
