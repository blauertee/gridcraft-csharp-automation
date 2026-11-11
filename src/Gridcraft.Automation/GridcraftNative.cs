namespace Gridcraft.Automation
{
    /// <summary>Information about the loaded native Gridcraft library.</summary>
    public static class GridcraftNative
    {
        /// <summary>The C ABI version this assembly was built against.</summary>
        public const uint ExpectedAbiVersion = 1;

        /// <summary>The C ABI version reported by the loaded native library.</summary>
        public static uint AbiVersion => NativeMethods.gc_abi_version();

        /// <summary>True when the loaded native library matches this assembly.</summary>
        public static bool IsCompatible => AbiVersion == ExpectedAbiVersion;
    }
}
