using System.Runtime.InteropServices;

namespace Gridcraft.Automation
{
    /// <summary>P/Invoke declarations for the gridcraft_ffi native library.</summary>
    internal static class NativeMethods
    {
        /// <summary>Resolves to gridcraft_ffi.dll on Windows and libgridcraft_ffi.so on Linux.</summary>
        internal const string Library = "gridcraft_ffi";

        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        internal static extern uint gc_abi_version();
    }
}
