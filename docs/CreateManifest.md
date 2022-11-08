# Create Manifest

[ShipEngine](www.shipengine.com) allows you programmatically create shipping manifests. Please see [our docs](https://www.shipengine.com/docs/shipping/manifests/) to learn more about creating manifests.

## Input Parameters

The `CreateManifest` method accepts manifest related params. You can view the properties here[`Manifests.Param`](https://github.com/ShipEngine/shipengine-dotnet/blob/main/ShipEngine/Models/Dto/Manifests/Params.cs).

## Output

The `CreateManifest` method returns the manifest that was created.
You can view the properties here [`CreateManifest.Result`](https://github.com/ShipEngine/shipengine-dotnet/blob/main/ShipEngine/Models/Dto/Manifests/Result.cs)

# Example

```csharp
using ShipEngineSDK;
using System.Threading.Tasks;
using System;
using ShipEngineSDK.Manifests;
using System.Collections.Generic;
using ShipEngineSDK.Common.Enums;
using ShipEngineSDK.Common;

public class Example
{
  public async Task<Result> CreateImplicitManifest()
  {
    var shipEngine = new ShipEngine("api_key");

    var implicitManifestParams = new ShipEngineSDK.Manifests.Params
    {
      CarrierId = "se-423887",
      WarehouseId = "se-8298517",
      ShipDate = new DateTime(2022, 11, 04)
    };

    try
    {
      var result = await shipEngine.CreateManifest(implicitManifestParams);
      return result;
    }
    catch (ShipEngineException e)
    {
      Console.WriteLine("Error creating manifest");
      throw e;
    }
  }
  
  public async Task<Result> CreateExplicitManifest()
  {
    var shipEngine = new ShipEngine("api_key");

    var explicitManifestParams = new ShipEngineSDK.Manifests.Params
    {
      LabelIds = new List<string>(){"se-81223599"},
    };

    try
    {
      var result = await shipEngine.CreateManifest(explicitManifestParams);
      return result;
    }
    catch (ShipEngineException e)
    {
      Console.WriteLine("Error creating manifest");
      throw e;
    }
  }
}
```

## Example Output

### Successful Create Manifest result

```csharp
{Result}
  Manifests: [
    ManifestId: "se-123456"
    FormId: "se-654321"
    CreatedAt: "2022-10-25T00:13:52.147Z"
    ShipDate: "2022-10-24T00:00:00Z"
    Shipments: 1
    LabelIds: ["se-121368231"]
    WarehouseId: "se-8298517"
    SubmissionId: "9475711201080070018360"
    CarrierId: "se-3237864"
    ManifestDownload: {ManifestDownload}
      Href: "https://api.shipengine.com/v1/downloads/10/8xN08ccHcEW-bpqfkDIxOQ/manifest-329620.pdf" 
  ]
```
