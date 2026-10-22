# .NET Version Upgrade Plan

## Overview

**Target**: Upgrade `LL2FERC.Test` from `net8.0` to `net10.0` while keeping its `netstandard2.0` library dependency compatible.
**Scope**: One SDK-style executable/test project plus full-solution validation; no package updates or API migrations are currently indicated by the assessment.

### Selected Strategy
**All-At-Once** — Upgrade all applicable project changes simultaneously in a single operation.
**Rationale**: The assessed target is a small modern SDK-style project with no incompatible packages or breaking API changes. The referenced `LL2FERC` library remains `netstandard2.0` to preserve its broad package compatibility.

## Tasks

### 01-prerequisites: Verify .NET 10 SDK and repository configuration

Confirm that the .NET 10 SDK is installed and that any repository-level SDK selection is compatible with `net10.0`. Review the target project configuration and its `netstandard2.0` project reference before modifying the target framework.

**Done when**: The required SDK/toolchain is available, repository configuration is compatible, and the target project is ready for the framework update.

---

### 02-upgrade-test-project: Upgrade LL2FERC.Test to .NET 10

Update `LL2FERC.Test/LL2FERC.Test.csproj` from `net8.0` to `net10.0`. Restore and build the project, addressing any compilation or framework compatibility issues that arise. Do not change the referenced `LL2FERC` library's `netstandard2.0` target because it is compatible with the upgraded project and the user scoped the modernization to `LL2FERC.Test`.

**Done when**: `LL2FERC.Test` targets `net10.0`, restore succeeds, and the project builds without errors or warnings.

---

### 03-solution-validation: Validate build and tests

Build the complete solution and run the available test project after the target framework update. Confirm that the project reference from the `net10.0` project to the `netstandard2.0` library remains valid and document any deferred recommendations.

**Done when**: The solution builds warning-free, all discovered tests pass, and no dependency conflicts remain.
