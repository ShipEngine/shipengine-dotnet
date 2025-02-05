# Void Label With Label Id

[ShipEngine](www.shipengine.com) allows you to attempt to void a previously purchased label. Please see [our docs](https://www.shipengine.com/docs/labels/voiding/) to learn more about voiding a label.

## Input Parameters

The `VoidLabelWithLabelId` method accepts a string that contains the label Id that is being voided.

## Output

The `VoidLabelWithLabelId` method returns an object that indicates the status of the void label request.
You can view the properties here [`VoidLabelWithLabelId.Result`](https://github.com/ShipEngine/shipengine-dotnet/blob/main/ShipEngine/Models/Dto/VoidLabelWithLabelId/Result.cs).

# Example

```csharp
using ShipEngineSDK;
using ShipEngineSDK.VoidLabelWithLabelId;
using System.Threading.Tasks;
using System;

public class Example
{

  public async Task<Result> VoidLabelWithLabelId()
  {
    var shipEngine = new ShipEngine("api_key");

    try
    {
      var result = await shipEngine.VoidLabelWithLabelId("se-81208131");
      return result;
    }
    catch (ShipEngineException e)
    {
      Console.WriteLine("Error validating address");
      throw e;
    }
  }

}

```

## Example Output

### Successful Address Validation

```csharp
{
  {Result}
    Approved: false
    Message: "Failed to refund label. Refund already in process Common Activities exception Exception with  code 0x005f030b; module 95, category 3, item 11"
}
```
