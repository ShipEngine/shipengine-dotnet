using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

public class TestUtils
{
    public readonly JsonSerializerSettings JsonSerializerSettings;

    public TestUtils()
    {
        JsonSerializerSettings = new JsonSerializerSettings()
        {
            NullValueHandling = NullValueHandling.Include,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            }
        };
    }
}