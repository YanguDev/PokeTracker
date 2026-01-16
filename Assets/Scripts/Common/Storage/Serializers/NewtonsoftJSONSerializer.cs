using Newtonsoft.Json;

namespace PokeTracker.Common.Storage.Serializers
{
    public class NewtonsoftJSONSerializer : ISerializer
    {
        private readonly JsonSerializerSettings settings;

        public NewtonsoftJSONSerializer() { }

        public NewtonsoftJSONSerializer(JsonSerializerSettings settings)
        {
            this.settings = settings;
        }

        public byte[] Serialize<T>(T data)
        {
            string serializedData = JsonConvert.SerializeObject(data, settings);
            return System.Text.Encoding.UTF8.GetBytes(serializedData);
        }

        public T Deserialize<T>(byte[] bytes)
        {
            string serializedData = System.Text.Encoding.UTF8.GetString(bytes);
            return JsonConvert.DeserializeObject<T>(serializedData, settings);
        }
    }
}
