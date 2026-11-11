# Gridcraft.Automation

A C# API for [Gridcraft](https://github.com/storytold/gridcraft): open, read, edit,
validate and save `.xlsx` files from .NET through Gridcraft's engine.

**Status:** early development. Nothing is usable yet.

## Targets

- `netstandard2.0` and `net5.0`, C# 9; builds in Visual Studio 2019 with the .NET 5 SDK.
- Native Gridcraft binaries for `win-x64` and `linux-x64`, shipped in the NuGet package.

## Planned layout

| Path | What |
|---|---|
| `native/gridcraft-ffi` | Rust `cdylib` exposing a C ABI over a pinned Gridcraft revision |
| `src/Gridcraft.Automation` | The C# API |
| `tests/Gridcraft.Automation.Tests` | xUnit tests on synthetic workbooks |
| `samples/` | Console samples |

## Building

Requirements: Rust 1.95 or newer, .NET 5 SDK (5.0.4xx, as shipped with Visual Studio 2019 16.11).

```sh
cd native/gridcraft-ffi
cargo build --release      # builds the native library and pins Gridcraft by revision
cd ../..
dotnet build -c Release    # or open Gridcraft.Automation.sln in Visual Studio 2019
dotnet test -c Release
dotnet run -c Release --project samples/HelloGridcraft
```

The test and sample projects copy the native library from `native/gridcraft-ffi/target/release/`,
so build the Rust crate first.
