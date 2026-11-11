using System;
using Gridcraft.Automation;

namespace HelloGridcraft
{
    internal static class Program
    {
        private static int Main()
        {
            Console.WriteLine($"Gridcraft native ABI version: {GridcraftNative.AbiVersion}");
            return GridcraftNative.IsCompatible ? 0 : 1;
        }
    }
}
