using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PinWin.BusinessLayer
{
    public class JsonKeysConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(KeysStringConverter.ToString((Keys)value));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return KeysStringConverter.FromString(reader.Value as string);
        }

        public override bool CanRead => true;

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Keys);
        }
    }
}