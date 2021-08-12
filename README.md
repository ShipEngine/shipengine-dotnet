[![ShipEngine](https://shipengine.github.io/img/shipengine-logo-wide.png)](https://shipengine.com)

# ShipEngine .NET

[![Build Status](https://github.com/ShipEngine/shipengine-js/workflows/CI-CD/badge.svg)](https://github.com/ShipEngine/shipengine-js/actions)
[![Coverage Status](https://coveralls.io/repos/github/ShipEngine/shipengine-js/badge.svg?branch=main)](https://coveralls.io/github/ShipEngine/shipengine-js?branch=main)

[![OS Compatibility](https://shipengine.github.io/img/badges/os-badges.svg)](https://github.com/ShipEngine/shipengine-js/actions)

:warning: **WARNING**: This is alpha software under active development. `Caveat emptor` until a 0.1.0 release is ready.

A C# library built on the [ShipEngine API](https://shipengine.com) offering low-level access as well as convenience methods.

<hr />

### Setup

- Install [.NET 5.x](https://dotnet.microsoft.com/download)

```
%> dotnet restore
%> dotnet tool restore

Please run dotnet format before pushing changes

%> dotnet format
```

## TESTS

Run the following command:

```

%> dotnet test

```

Run tests on file change:

```

%> dotnet watch -p ShipEngine.tests/ test

```
