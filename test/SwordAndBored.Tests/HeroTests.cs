using System;
using Xunit;

namespace SwordAndBored.Tests
{
    public class HeroTests
    {
        [Fact]
        public void HeroHasAName()
        {
            var hero = new Hero("JoJo");

            Assert.Equal("JoJo", hero.Name);
        }
    }
}
