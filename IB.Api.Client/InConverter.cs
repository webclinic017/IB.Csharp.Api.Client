namespace IB.Api.Client
{
    using System;
    using Newtonsoft.Json;

    internal class InConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(In) || t == typeof(In?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "body":
                    return In.Body;
                case "path":
                    return In.Path;
                case "query":
                    return In.Query;
            }
            throw new Exception("Cannot unmarshal type In");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (In)untypedValue;
            switch (value)
            {
                case In.Body:
                    serializer.Serialize(writer, "body");
                    return;
                case In.Path:
                    serializer.Serialize(writer, "path");
                    return;
                case In.Query:
                    serializer.Serialize(writer, "query");
                    return;
            }
            throw new Exception("Cannot marshal type In");
        }

        public static readonly InConverter Singleton = new InConverter();
    }
}
