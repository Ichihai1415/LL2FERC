# 01-prerequisites: Verify .NET 10 SDK and repository configuration

Confirm that the .NET 10 SDK is installed and that any repository-level SDK selection is compatible with `net10.0`. Review the target project configuration and its `netstandard2.0` project reference before modifying the target framework.

## Research findings

- The target project is `LL2FERC.Test/LL2FERC.Test.csproj`, an SDK-style executable currently targeting `net8.0`.
- It references `LL2FERC/LL2FERC.csproj`, which targets `netstandard2.0`; no package references or custom imports were reported.
- No `global.json` or `Directory.Build.props` was found in the repository root scan.
- `validate_dotnet_sdk_installation` reported a compatible .NET 10 SDK.
- The target project is suitable for `dotnet build`; no WPF, WinForms resources, legacy project format, or .NET Framework target was detected.

**Done when**: The required SDK/toolchain is available, repository configuration is compatible, and the target project is ready for the framework update.
