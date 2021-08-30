[![ShipEngine](https://shipengine.github.io/img/shipengine-logo-wide.png)](https://shipengine.com)

# ShipEngine .NET

![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/ShipEngine)
![GitHub](https://img.shields.io/github/license/ShipEngine/shipengine-dotnet)

[![Build Status](https://github.com/ShipEngine/shipengine-dotnet/workflows/CI-CD/badge.svg)](https://github.com/ShipEngine/shipengine-dotnet/actions)
[![Coverage Status](https://coveralls.io/repos/github/ShipEngine/shipengine-dotnet/badge.svg?branch=main)](https://coveralls.io/github/ShipEngine/shipengine-dotnet?branch=main)

[![OS Compatibility](https://shipengine.github.io/img/badges/os-badges.svg)](https://github.com/ShipEngine/shipengine-dotnet/actions)

:warning: **WARNING**: This is alpha software under active development. `Caveat emptor` until a 1.0.0 release is ready.

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

## Release

In the `ShipEngine.csproj` file, update to the desired version and push to the `main` branch.
The [Publish NuGet Github Actions](https://github.com/marketplace/actions/publish-nuget) will handle all the necessary github tags and nuget packaging and publishing.
