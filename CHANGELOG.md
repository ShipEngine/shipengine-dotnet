# Changelog

## 1.0.0

### Features

Implement the following SDK methods.

- `ValidateAddresses`
- `ListCarriers`
- `VoidLabelWithLabelId`
- `TrackUsingLabelId`
- `TrackUsingCarrierCodeAndTrackingNumber`
- `CreateLabelFromShipmentDetails`
- `CreateLabelFromRate`
- `GetRatesWithShipmentDetails`

## 1.0.7

### Features

Implement the following SDK methods.
- `CreateImplicitManifest`


## 1.1.0

### Added

Documentation for CreateManifest

### Changed

Rename CreateImplicitManifest method to CreateManifest, as it covers both implicit and explicit manifests.
Rename LabelDownload method to the more generic Download

### Fixed

Some documentation linking errors and minor typos

## 1.2.0

### Added

Method to Update Shipment By Shipment ID

### Changed

Moved Shipment Class to the common models, as it is used in multiple requests.
Updated package class to use the Shipment Package class in Rate Requests. 
