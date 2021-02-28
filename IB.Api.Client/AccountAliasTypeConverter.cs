namespace IB.Api.Client
{
    using System;
    using Newtonsoft.Json;

    internal class AccountAliasTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AccountAliasType) || t == typeof(AccountAliasType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "boolean":
                    return AccountAliasType.Boolean;
                case "integer":
                    return AccountAliasType.Integer;
                case "number":
                    return AccountAliasType.Number;
                case "object":
                    return AccountAliasType.Object;
                case "string":
                    return AccountAliasType.String;
            }
            throw new Exception("Cannot unmarshal type AccountAliasType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AccountAliasType)untypedValue;
            switch (value)
            {
                case AccountAliasType.Boolean:
                    serializer.Serialize(writer, "boolean");
                    return;
                case AccountAliasType.Integer:
                    serializer.Serialize(writer, "integer");
                    return;
                case AccountAliasType.Number:
                    serializer.Serialize(writer, "number");
                    return;
                case AccountAliasType.Object:
                    serializer.Serialize(writer, "object");
                    return;
                case AccountAliasType.String:
                    serializer.Serialize(writer, "string");
                    return;
            }
            throw new Exception("Cannot marshal type AccountAliasType");
        }

        public static readonly AccountAliasTypeConverter Singleton = new AccountAliasTypeConverter();
    }
}
