# 02-upgrade-test-project: Upgrade LL2FERC.Test to .NET 10

Update `LL2FERC.Test/LL2FERC.Test.csproj` from `net8.0` to `net10.0`. Restore and build the project, addressing any compilation or framework compatibility issues that arise. Do not change the referenced `LL2FERC` library's `netstandard2.0` target because it is compatible with the upgraded project and the user scoped the modernization to `LL2FERC.Test`.

## Research findings

- Assessment confirms `LL2FERC.Test.csproj` is SDK-style, a `DotNetCoreApp`, currently `net8.0`, with one mandatory issue: `Project.0002` requires the target framework change to `net10.0`.
- The project contains one project reference to `LL2FERC/LL2FERC.csproj`, which remains `netstandard2.0`; no package references, incompatible packages, API issues, or test-coverage baseline work were identified.
- The target framework is defined directly in `LL2FERC.Test/LL2FERC.Test.csproj` and no repository-level `global.json` or `Directory.Build.props` overrides it.
- No `// STUB:` markers were found in `LL2FERC.Test` or `LL2FERC` source files.
- This is an atomic single-project TFM replacement with no decomposition needed. Use `dotnet build` with restore; no special MSBuild tooling is required.

**Done when**: `LL2FERC.Test` targets `net10.0`, restore succeeds, and the project builds without errors or warnings.
