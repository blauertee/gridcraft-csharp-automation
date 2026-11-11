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
