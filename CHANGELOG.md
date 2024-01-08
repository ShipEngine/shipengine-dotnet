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


## 1.1.1

### Added

### Changed

### Fixed

The Customs Item Quantity type has been changed to integer type for CreateLabelFromShipmentDetails model.


## 1.1.2

### Fixed

ShipmentItem.Quantity is now an int? instead of a double?.

## 1.1.3

### Added

### Changed

### Fixed

Set casing of letter label layout enum

## 1.1.4

### Fixed

CreateLabelFromShipmentDetails parameters causing problems when unused has been made optional.

## 1.1.5

### Changed

Update default timeout to 60s