using System;

namespace Newtonsoft.Json.Extensions
{
    public static class JsonConverter
    {
        public static T TryDeserializeObject<T>(string value, Type type) where T : class
        {
            try
            {
                return JsonConvert.DeserializeObject(value, type) as T;
            }
            catch (Exception)
            {
                return default;
            }
        }
    }
}