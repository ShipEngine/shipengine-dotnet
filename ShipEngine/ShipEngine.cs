using System;
using System.Runtime.InteropServices;

using FluentValidation.Results;

using ShipEngine.Services;

namespace ShipEngine
{
  sealed public class ShipEngine
  {
    private readonly string Version = "0.0.1";

    // SERVICES
    public TagsService? Tags;

    public ShipEngine(string apiKey)
    {
      ShipEngineConfig config = new ShipEngineConfig(apiKey);
      config.UserAgent = DeriveUserAgent();
      Build(config);
    }

    public ShipEngine(ShipEngineConfig config)
    {
      config.UserAgent = DeriveUserAgent();
      Build(config);
    }

    private void Build(ShipEngineConfig config) {
      ShipEngineConfigValidator validator = new ShipEngineConfigValidator();
      ValidationResult result = validator.Validate(config);
      if (result.IsValid == false) {
        throw new ArgumentException(result.Errors.ToString());
      }

      ShipEngineClient client = new ShipEngineClient(config);

      this.Tags = new TagsService(client);
    }
    private string DeriveUserAgent()
    {
      string os = Environment.OSVersion.ToString().Replace(" ", "/");
      string runtime = RuntimeInformation.FrameworkDescription.Replace(" ", "/");

      return $"shipengine-dotnet/{Version} {os} {runtime}";
    }
  }
}
