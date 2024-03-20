using Newtonsoft.Json;

namespace FastIO;

public class Output
{
    public static void Debug(object element)
    {
        Console.WriteLine(JsonConvert.SerializeObject(element));
    }
}