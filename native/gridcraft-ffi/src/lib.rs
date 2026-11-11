//! C ABI over the Gridcraft engine.
//!
//! This is the skeleton: it only proves that the engine links and that .NET can call in.
//! Sessions, commands and typed block access follow in the native-layer work package.

/// Version of this C ABI. Bumped whenever an exported signature changes, so the
/// .NET side can refuse a native library it does not understand.
pub const ABI_VERSION: u32 = 1;

/// Returns [`ABI_VERSION`].
#[no_mangle]
pub extern "C" fn gc_abi_version() -> u32 {
    ABI_VERSION
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn abi_version_is_exported() {
        assert_eq!(gc_abi_version(), ABI_VERSION);
    }

    #[test]
    fn engine_links_and_runs_a_command() {
        let mut session = gridcraft_engine::Session::new();
        session.new_workbook();
        let result = session.execute("cell.set", serde_json::json!({"cell": "A1", "input": "42"}));
        assert!(result.is_ok(), "cell.set failed: {result:?}");
    }
}
