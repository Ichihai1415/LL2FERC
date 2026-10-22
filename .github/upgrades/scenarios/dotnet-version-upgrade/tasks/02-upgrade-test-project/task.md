# 02-upgrade-test-project: Upgrade LL2FERC.Test to .NET 10

Update `LL2FERC.Test/LL2FERC.Test.csproj` from `net8.0` to `net10.0`. Restore and build the project, addressing any compilation or framework compatibility issues that arise. Do not change the referenced `LL2FERC` library's `netstandard2.0` target because it is compatible with the upgraded project and the user scoped the modernization to `LL2FERC.Test`.

**Done when**: `LL2FERC.Test` targets `net10.0`, restore succeeds, and the project builds without errors or warnings.
