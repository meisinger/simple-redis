using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Simple.Redis.Utilities
{
    internal static class RedisSerializer
    {
        private static readonly JsonSerializerSettings settings = new JsonSerializerSettings
        {
            Formatting = Formatting.None,
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            MissingMemberHandling = MissingMemberHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple,
            TypeNameHandling = TypeNameHandling.None,
        };

        internal static TType DeserializeType<TType>(byte[] bytes, TType anonymousType)
        {
            var content = Encoding.UTF8.GetString(bytes);
            return DeserializeType(content, anonymousType);
        }

        internal static TType DeserializeType<TType>(string content, TType anonymousType)
        {
            return JsonConvert.DeserializeAnonymousType(content, anonymousType);
        }

        internal static T Deserialize<T>(byte[] bytes)
        {
            var content = Encoding.UTF8.GetString(bytes);
            return Deserialize<T>(content);
        }

        internal static T Deserialize<T>(string content)
        {
            return JsonConvert.DeserializeObject<T>(content);
        }

        internal static byte[] SerializeToBytes<T>(T item)
        {
            using (var stream = new MemoryStream())
            using (var writer = new StreamWriter(stream))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                var serializer = JsonSerializer.Create(settings);
                serializer.Serialize(jsonWriter, item);

                writer.Flush();
                return stream.ToArray();
            }
        }

        internal static string SerializeToString<T>(T item)
        {
            using (var writer = new StringWriter())
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                var serializer = JsonSerializer.Create(settings);
                serializer.Serialize(jsonWriter, item);

                writer.Flush();
                return writer.ToString();
            }
        }
    }
}
