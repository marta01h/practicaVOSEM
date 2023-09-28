using Newtonsoft.Json;


namespace ClassLibrary1
{
    public class DataSerializer
    {
        public static string Serialize<T>(T data)
        {
            return JsonConvert.SerializeObject(data);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}