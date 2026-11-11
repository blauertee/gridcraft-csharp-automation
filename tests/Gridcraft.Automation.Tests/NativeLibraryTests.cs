using Xunit;

namespace Gridcraft.Automation.Tests
{
    public class NativeLibraryTests
    {
        [Fact]
        public void NativeLibraryLoadsAndMatchesTheAbi()
        {
            Assert.Equal(GridcraftNative.ExpectedAbiVersion, GridcraftNative.AbiVersion);
            Assert.True(GridcraftNative.IsCompatible);
        }
    }
}
