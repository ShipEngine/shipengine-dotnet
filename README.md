[![ShipEngine](https://shipengine.github.io/img/shipengine-logo-wide.png)](https://shipengine.com)

# ShipEngine .NET

:warning: **WARNING**: This is alpha software under active development. `Caveat emptor` until a 0.1.0 release is ready.

A C# library built on the [ShipEngine API](https://shipengine.com) offering low-level access as well as convenience methods.

<hr />

## TESTS

In order for tests to pass, you need to have [Prism](https://stoplight.io/open-source/prism) running with the current [OpenApi](http://spec.openapis.org/oas/v3.0.3) spec:

```
%> prism mock --port 9999 ../shipengine-api-definition/v2.oas3.dist.yaml
```
