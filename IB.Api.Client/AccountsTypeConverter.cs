namespace IB.Api.Client
{
    using System;
    using Newtonsoft.Json;

    internal class AccountsTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AccountsType) || t == typeof(AccountsType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "array")
            {
                return AccountsType.Array;
            }
            throw new Exception("Cannot unmarshal type AccountsType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AccountsType)untypedValue;
            if (value == AccountsType.Array)
            {
                serializer.Serialize(writer, "array");
                return;
            }
            throw new Exception("Cannot marshal type AccountsType");
        }

        public static readonly AccountsTypeConverter Singleton = new AccountsTypeConverter();
    }
}
