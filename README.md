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


## Overview

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.1.202501091801
- SDK version: 3.0.0
- Generator version: 7.7.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://www.shipengine.com/contact/](https://www.shipengine.com/contact/)

<a id="frameworks-supported"></a>
## Frameworks supported
- .NET Standard >=2.0
- .NET Core >=2.0
- .NET Framework >=4.6.2

<a id="documentation-for-api-endpoints"></a>
## Methods

API | Method | Description
------------ | ------------- | -------------
*Account* | [**CreateAccountImage**](docs//apis/AccountApi.md#createaccountimage) | Create an Account Image
*Account* | [**DeleteAccountImageById**](docs//apis/AccountApi.md#deleteaccountimagebyid) | Delete Account Image By Id
*Account* | [**GetAccountSettingsImagesById**](docs//apis/AccountApi.md#getaccountsettingsimagesbyid) | Get Account Image By ID
*Account* | [**ListAccountImages**](docs//apis/AccountApi.md#listaccountimages) | List Account Images
*Account* | [**ListAccountSettings**](docs//apis/AccountApi.md#listaccountsettings) | List Account Settings
*Account* | [**UpdateAccountSettingsImagesById**](docs//apis/AccountApi.md#updateaccountsettingsimagesbyid) | Update Account Image By ID
*Addresses* | [**ParseAddress**](docs//apis/AddressesApi.md#parseaddress) | Parse an address
*Addresses* | [**ValidateAddress**](docs//apis/AddressesApi.md#validateaddress) | Validate An Address
*Batches* | [**AddToBatch**](docs//apis/BatchesApi.md#addtobatch) | Add to a Batch
*Batches* | [**CreateBatch**](docs//apis/BatchesApi.md#createbatch) | Create A Batch
*Batches* | [**DeleteBatch**](docs//apis/BatchesApi.md#deletebatch) | Delete Batch By Id
*Batches* | [**GetBatchByExternalId**](docs//apis/BatchesApi.md#getbatchbyexternalid) | Get Batch By External ID
*Batches* | [**GetBatchById**](docs//apis/BatchesApi.md#getbatchbyid) | Get Batch By ID
*Batches* | [**ListBatchErrors**](docs//apis/BatchesApi.md#listbatcherrors) | Get Batch Errors
*Batches* | [**ListBatches**](docs//apis/BatchesApi.md#listbatches) | List Batches
*Batches* | [**ProcessBatch**](docs//apis/BatchesApi.md#processbatch) | Process Batch ID Labels
*Batches* | [**RemoveFromBatch**](docs//apis/BatchesApi.md#removefrombatch) | Remove From Batch
*Batches* | [**UpdateBatch**](docs//apis/BatchesApi.md#updatebatch) | Update Batch By Id
*CarrierAccounts* | [**ConnectCarrier**](docs//apis/CarrierAccountsApi.md#connectcarrier) | Connect a carrier account
*CarrierAccounts* | [**DisconnectCarrier**](docs//apis/CarrierAccountsApi.md#disconnectcarrier) | Disconnect a carrier
*CarrierAccounts* | [**GetCarrierSettings**](docs//apis/CarrierAccountsApi.md#getcarriersettings) | Get carrier settings
*CarrierAccounts* | [**UpdateCarrierSettings**](docs//apis/CarrierAccountsApi.md#updatecarriersettings) | Update carrier settings
*Carriers* | [**AddFundsToCarrier**](docs//apis/CarriersApi.md#addfundstocarrier) | Add Funds To Carrier
*Carriers* | [**DisconnectCarrierById**](docs//apis/CarriersApi.md#disconnectcarrierbyid) | Disconnect Carrier by ID
*Carriers* | [**GetCarrierById**](docs//apis/CarriersApi.md#getcarrierbyid) | Get Carrier By ID
*Carriers* | [**GetCarrierOptions**](docs//apis/CarriersApi.md#getcarrieroptions) | Get Carrier Options
*Carriers* | [**ListCarrierPackageTypes**](docs//apis/CarriersApi.md#listcarrierpackagetypes) | List Carrier Package Types
*Carriers* | [**ListCarrierServices**](docs//apis/CarriersApi.md#listcarrierservices) | List Carrier Services
*Carriers* | [**ListCarriers**](docs//apis/CarriersApi.md#listcarriers) | List Carriers
*Downloads* | [**DownloadFile**](docs//apis/DownloadsApi.md#downloadfile) | Download File
*Insurance* | [**AddFundsToInsurance**](docs//apis/InsuranceApi.md#addfundstoinsurance) | Add Funds To Insurance
*Insurance* | [**ConnectInsurer**](docs//apis/InsuranceApi.md#connectinsurer) | Connect a Shipsurance Account
*Insurance* | [**DisconnectInsurer**](docs//apis/InsuranceApi.md#disconnectinsurer) | Disconnect a Shipsurance Account
*Insurance* | [**GetInsuranceBalance**](docs//apis/InsuranceApi.md#getinsurancebalance) | Get Insurance Funds Balance
*Labels* | [**CreateLabel**](docs//apis/LabelsApi.md#createlabel) | Purchase Label
*Labels* | [**CreateLabelFromRate**](docs//apis/LabelsApi.md#createlabelfromrate) | Purchase Label with Rate ID
*Labels* | [**CreateLabelFromShipment**](docs//apis/LabelsApi.md#createlabelfromshipment) | Purchase Label with Shipment ID
*Labels* | [**CreateReturnLabel**](docs//apis/LabelsApi.md#createreturnlabel) | Create a return label
*Labels* | [**GetLabelByExternalShipmentId**](docs//apis/LabelsApi.md#getlabelbyexternalshipmentid) | Get Label By External Shipment ID
*Labels* | [**GetLabelById**](docs//apis/LabelsApi.md#getlabelbyid) | Get Label By ID
*Labels* | [**GetTrackingLogFromLabel**](docs//apis/LabelsApi.md#gettrackinglogfromlabel) | Get Label Tracking Information
*Labels* | [**ListLabels**](docs//apis/LabelsApi.md#listlabels) | List labels
*Labels* | [**VoidLabel**](docs//apis/LabelsApi.md#voidlabel) | Void a Label By ID
*Manifests* | [**CreateManifest**](docs//apis/ManifestsApi.md#createmanifest) | Create Manifest
*Manifests* | [**GetManifestById**](docs//apis/ManifestsApi.md#getmanifestbyid) | Get Manifest By Id
*Manifests* | [**GetManifestRequestById**](docs//apis/ManifestsApi.md#getmanifestrequestbyid) | Get Manifest Request By Id
*Manifests* | [**ListManifests**](docs//apis/ManifestsApi.md#listmanifests) | List Manifests
*PackagePickups* | [**DeleteScheduledPickup**](docs//apis/PackagePickupsApi.md#deletescheduledpickup) | Delete a Scheduled Pickup
*PackagePickups* | [**GetPickupById**](docs//apis/PackagePickupsApi.md#getpickupbyid) | Get Pickup By ID
*PackagePickups* | [**ListScheduledPickups**](docs//apis/PackagePickupsApi.md#listscheduledpickups) | List Scheduled Pickups
*PackagePickups* | [**SchedulePickup**](docs//apis/PackagePickupsApi.md#schedulepickup) | Schedule a Pickup
*PackageTypes* | [**CreatePackageType**](docs//apis/PackageTypesApi.md#createpackagetype) | Create Custom Package Type
*PackageTypes* | [**DeletePackageType**](docs//apis/PackageTypesApi.md#deletepackagetype) | Delete A Custom Package By ID
*PackageTypes* | [**GetPackageTypeById**](docs//apis/PackageTypesApi.md#getpackagetypebyid) | Get Custom Package Type By ID
*PackageTypes* | [**ListPackageTypes**](docs//apis/PackageTypesApi.md#listpackagetypes) | List Custom Package Types
*PackageTypes* | [**UpdatePackageType**](docs//apis/PackageTypesApi.md#updatepackagetype) | Update Custom Package Type By ID
*Rates* | [**CalculateRates**](docs//apis/RatesApi.md#calculaterates) | Get Shipping Rates
*Rates* | [**CompareBulkRates**](docs//apis/RatesApi.md#comparebulkrates) | Get Bulk Rates
*Rates* | [**EstimateRates**](docs//apis/RatesApi.md#estimaterates) | Estimate Rates
*Rates* | [**GetRateById**](docs//apis/RatesApi.md#getratebyid) | Get Rate By ID
*ServicePoints* | [**ServicePointsGetById**](docs//apis/ServicePointsApi.md#servicepointsgetbyid) | Get Service Point By ID
*ServicePoints* | [**ServicePointsList**](docs//apis/ServicePointsApi.md#servicepointslist) | List Service Points
*Shipments* | [**CancelShipments**](docs//apis/ShipmentsApi.md#cancelshipments) | Cancel a Shipment
*Shipments* | [**CreateShipments**](docs//apis/ShipmentsApi.md#createshipments) | Create Shipments
*Shipments* | [**GetShipmentByExternalId**](docs//apis/ShipmentsApi.md#getshipmentbyexternalid) | Get Shipment By External ID
*Shipments* | [**GetShipmentById**](docs//apis/ShipmentsApi.md#getshipmentbyid) | Get Shipment By ID
*Shipments* | [**ListShipmentRates**](docs//apis/ShipmentsApi.md#listshipmentrates) | Get Shipment Rates
*Shipments* | [**ListShipments**](docs//apis/ShipmentsApi.md#listshipments) | List Shipments
*Shipments* | [**ParseShipment**](docs//apis/ShipmentsApi.md#parseshipment) | Parse shipping info
*Shipments* | [**ShipmentsListTags**](docs//apis/ShipmentsApi.md#shipmentslisttags) | Get Shipment Tags
*Shipments* | [**ShipmentsUpdateTags**](docs//apis/ShipmentsApi.md#shipmentsupdatetags) | Update Shipments Tags
*Shipments* | [**TagShipment**](docs//apis/ShipmentsApi.md#tagshipment) | Add Tag to Shipment
*Shipments* | [**UntagShipment**](docs//apis/ShipmentsApi.md#untagshipment) | Remove Tag from Shipment
*Shipments* | [**UpdateShipment**](docs//apis/ShipmentsApi.md#updateshipment) | Update Shipment By ID
*Tags* | [**CreateTag**](docs//apis/TagsApi.md#createtag) | Create a New Tag
*Tags* | [**DeleteTag**](docs//apis/TagsApi.md#deletetag) | Delete Tag
*Tags* | [**ListTags**](docs//apis/TagsApi.md#listtags) | Get Tags
*Tags* | [**RenameTag**](docs//apis/TagsApi.md#renametag) | Update Tag Name
*Tokens* | [**TokensGetEphemeralToken**](docs//apis/TokensApi.md#tokensgetephemeraltoken) | Get Ephemeral Token
*Tracking* | [**GetTrackingLog**](docs//apis/TrackingApi.md#gettrackinglog) | Get Tracking Information
*Tracking* | [**StartTracking**](docs//apis/TrackingApi.md#starttracking) | Start Tracking a Package
*Tracking* | [**StopTracking**](docs//apis/TrackingApi.md#stoptracking) | Stop Tracking a Package
*Warehouses* | [**CreateWarehouse**](docs//apis/WarehousesApi.md#createwarehouse) | Create Warehouse
*Warehouses* | [**DeleteWarehouse**](docs//apis/WarehousesApi.md#deletewarehouse) | Delete Warehouse By ID
*Warehouses* | [**GetWarehouseById**](docs//apis/WarehousesApi.md#getwarehousebyid) | Get Warehouse By Id
*Warehouses* | [**ListWarehouses**](docs//apis/WarehousesApi.md#listwarehouses) | List Warehouses
*Warehouses* | [**UpdateWarehouse**](docs//apis/WarehousesApi.md#updatewarehouse) | Update Warehouse By Id
*Warehouses* | [**UpdateWarehouseSettings**](docs//apis/WarehousesApi.md#updatewarehousesettings) | Update Warehouse Settings
*Webhooks* | [**CreateWebhook**](docs//apis/WebhooksApi.md#createwebhook) | Create a Webhook
*Webhooks* | [**DeleteWebhook**](docs//apis/WebhooksApi.md#deletewebhook) | Delete Webhook By ID
*Webhooks* | [**GetWebhookById**](docs//apis/WebhooksApi.md#getwebhookbyid) | Get Webhook By ID
*Webhooks* | [**ListWebhooks**](docs//apis/WebhooksApi.md#listwebhooks) | List Webhooks
*Webhooks* | [**UpdateWebhook**](docs//apis/WebhooksApi.md#updatewebhook) | Update a Webhook


## Legacy Methods

These methods have been deprecated in favor of the methods listed above, but are still in the SDK.

- [`CreateLabelFromRate`](./docs/legacy/CreateLabelFromRate.md) - When retrieving rates for shipments using the `GetRatesWithShipmentDetails` method, the returned information contains a `RateId` property that can be used to purchase a label without having to refill in the shipment information repeatedly.
- [`CreateLabelFromShipmentDetails`](./docs/legacy/CreateLabelFromShipmentDetails.md) - Purchase and print a label for shipment.
- [`GetRatesWithShipmentDetails`](./docs/legacy/GetRatesWithShipmentDetails.md) - Given some shipment details and rate options, this method returns a list of rate quotes.
- [`ListCarriers`](./docs/legacy/ListCarriers.md) - Returns a list of carrier accounts that have been connected through
  the [ShipEngine dashboard](https://www.shipengine.com/docs/carriers/setup/).
- [`TrackUsingLabelId`](./docs/legacy/TrackUsingLabelId.md) - Track a package by its associated label ID.
- [`TrackUsingCarrierCodeAndTrackingNumber`](./docs/legacy/TrackUsingCarrierCodeAndTrackingNumber.md) - Track a package for a given carrier and tracking number.
- [`ValidateAddresses`](./docs/legacy/ValidateAddresses.md) - Indicates whether the provided addresses are valid. If the addresses are valid, the method returns a normalized version based on the standards of the country in which the address resides. If an address cannot be normalized, an error is returned.
- [`VoidLabelWithLabelId`](./docs/legacy/VoidLabelWithLabelId.md) - Void a label with its Label ID.
- [`CreateManifests`](./docs/legacy/CreateManifest.md) - Create a shipment manifest.

## Contributing

Contributions, enhancements, and bug-fixes are welcome! [Open an issue](https://github.com/ShipEngine/shipengine-dotnet/issues) on GitHub and [submit a pull request](https://github.com/ShipEngine/shipengine-dotnet/pulls).

### Building

To build the project locally on your computer:

1. **Clone this repo**<br>
   `git clone https://github.com/ShipEngine/shipengine-dotnet.git`

2. **Install [.NET 8.x](https://dotnet.microsoft.com/download)**

3. **Install dependencies**<br>
   `dotnet restore`

4. **Build the code**<br>
   `dotnet build`

5. **Format the code**<br>
   `dotnet format`

6. **Run the tests**<br>
   `dotnet test`<br><br>
   By default, the test project targets all supported frameworks, if your environment only supports a subset then you can specify in the CLI. <br><br>
   `dotnet test -f net8.0`

### Generating from OpenAPI

To regenerate the SDK from the OpenAPI spec, you will first need to get the latest version of the spec.  It can be downloaded from the [online documentation](https://shipengine.github.io/shipengine-openapi/)
and should be saved to `./generation/swagger.json`.  Then run `npm run generate` from the command line.  This will regenerate all the API calls and models, but not docs or tests.

The templates for autogeneration were extracted using the command:
```bash
npx @openapitools/openapi-generator-cli author template -g csharp -o generation/templates
```

## Release
Create a [fork](https://docs.github.com/en/get-started/quickstart/contributing-to-projects) for your changes.

Update the [Changelog](./CHANGELOG.md) with any relevant new features or bug fixes and modify the `packageVersion` property in the `.openapitools.json` file to match the new version.

In the `ShipEngine.csproj` file, update to the desired version (using [semantic versioning](https://semver.org/)) and push to your fork.

Run `dotnet format`

Create a pull request.

Once a member of the ShipEngine team reviews your PR and it's merged to main, the build pipeline will handle all the necessary github tags and nuget packaging and publishing.
