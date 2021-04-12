using Xunit;

namespace Jellyfish.Test
{
    public class JellyFishTestManager
    {
        [Fact]
        public void GetDirectionFromString()
        {
            var value = JeliFish.JellyFishManager.GetDirectionFromString("11E RFRFRFRF");

            //Assert
            Assert.Equal("E", value);
        }

        [Fact]
        public void GetValidString()
        {
            var value = JeliFish.JellyFishManager.GetValidString("11E RFRFRFRF");

            //Assert
            Assert.Equal("11          ", value);
        }

        [Fact]
        public void GetStartDirection()
        {
            var value = JeliFish.JellyFishManager.GetStartDirection("11E RFRFRFRF");

            //Assert
            Assert.Equal(1, value);
        }

    }
}
