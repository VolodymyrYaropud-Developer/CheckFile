using System.Text.Json;

namespace CheckFile
{
    internal class MySerialization
    {
        public DataFromConfiguration SerializeTo(string jsonString)
        {
            var result = JsonSerializer.Deserialize<DataFromConfiguration>(jsonString);
            return result?? new DataFromConfiguration { dateFormat = default, IntervalInSeconds = 10};
        }
    }
}
