[![ShipEngine](https://shipengine.github.io/img/shipengine-logo-wide.png)](https://shipengine.com)

# ShipEngine .NET SDK

### The official ShipEngine SDK for .NET

![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/ShipEngine)
![GitHub](https://img.shields.io/github/license/ShipEngine/shipengine-dotnet)

[![Build Status](https://github.com/ShipEngine/shipengine-dotnet/actions/workflows/ci-cd.yaml/badge.svg)](https://github.com/ShipEngine/shipengine-dotnet/actions/workflows/ci-cd.yaml)
[![Coverage Status](https://coveralls.io/repos/github/ShipEngine/shipengine-dotnet/badge.svg?branch=main)](https://coveralls.io/github/ShipEngine/shipengine-dotnet?branch=main)

[![OS Compatibility](https://shipengine.github.io/img/badges/os-badges.svg)](https://github.com/ShipEngine/shipengine-dotnet/actions)

[Nuget Page](https://www.nuget.org/packages/ShipEngine/)

## Quick Start

Install ShipEngine .NET SDK via the [.NET CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/).

```bash
dotnet add package ShipEngine
```

The only configuration requirement is an [API key](https://www.shipengine.com/docs/auth/#api-keys).

```csharp
using ShipEngineSDK;

var shipengine = new ShipEngine("___YOUR_API_KEY_HERE__");
```

## Methods

- [`CreateLabelFromRate`](./docs/CreateLabelFromRate.md) - When retrieving rates for shipments using the `GetRatesWithShipmentDetails` method, the returned information contains a `RateId` property that can be used to purchase a label without having to refill in the shipment information repeatedly.
- [`CreateLabelFromShipmentDetails`](./docs/CreateLabelFromShipmentDetails.md) - Purchase and print a label for shipment.
- [`GetRatesWithShipmentDetails`](./docs/GetRatesWithShipmentDetails.md) - Given some shipment details and rate options, this method returns a list of rate quotes.
- [`ListCarriers`](./docs/ListCarriers.md) - Returns a list of carrier accounts that have been connected through
  the [ShipEngine dashboard](https://www.shipengine.com/docs/carriers/setup/).
- [`TrackUsingLabelId`](./docs/TrackUsingLabelId.md) - Track a package by its associated label ID.
- [`TrackUsingCarrierCodeAndTrackingNumber`](./docs/TrackUsingCarrierCodeAndTrackingNumber.md) - Track a package for a given carrier and tracking number.
- [`ValidateAddresses`](./docs/ValidateAddresses.md) - Indicates whether the provided addresses are valid. If the addresses are valid, the method returns a normalized version based on the standards of the country in which the address resides. If an address cannot be normalized, an error is returned.
- [`VoidLabelWithLabelId`](./docs/VoidLabelWithLabelId.md) - Void a label with its Label ID.
- [`CreateManifests`](./docs/CreateManifest.md) - Create a shipment manifest.

## Contributing

Contributions, enhancements, and bug-fixes are welcome! [Open an issue](https://github.com/ShipEngine/shipengine-dotnet/issues) on GitHub and [submit a pull request](https://github.com/ShipEngine/shipengine-dotnet/pulls).

### Building

To build the project locally on your computer:

1. **Clone this repo**<br>
   `git clone https://github.com/ShipEngine/shipengine-dotnet.git`

2. **Install [.NET 5.x](https://dotnet.microsoft.com/download)**

3. **Install dependencies**<br>
   `dotnet restore`

4. **Build the code**<br>
   `dotnet build`

5. **Format the code**<br>
   `dotnet format`

6. **Run the tests**<br>
   `dotnet test`<br><br>
   By default, the test project targets all supported frameworks, if your environment only supports a subset then you can specify in the CLI. <br><br>
   `dotnet test -f net5.0`

### Generating from OpenAPI

The templates for autogeneration were extracted using the command:
```bash
npx @openapitools/openapi-generator-cli author template -g csharp -o generation/templates
```

## Release
Create a [fork](https://docs.github.com/en/get-started/quickstart/contributing-to-projects) for your changes.

Update the [Changelog](./CHANGELOG.md) with any relevant new features or bug fixes.

In the `ShipEngine.csproj` file, update to the desired version (using [semantic versioning](https://semver.org/)) and push to your fork.

Run `dotnet format`

Create a pull request.

Once a member of the ShipEngine team reviews your PR and it's merged to main, the build pipeline will handle all the necessary github tags and nuget packaging and publishing.
