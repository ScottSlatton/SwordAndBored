using System;
using Xunit;

namespace SwordAndBored.Tests
{
    public class HeroTests
    {
        [Fact]
        public void HeroHasANameAndBaseStats()
        {
            var hero = new Hero("JoJo");

            Assert.Equal("JoJo", hero.Name);
            Assert.Equal(1, hero.Speed);
            Assert.Equal(0, hero.Defense);
            Assert.Equal(1, hero.Attack);
            Assert.Equal(1, hero.Level);
            Assert.Equal(100, hero.Health);
            Assert.Equal(0, hero.Gold);

        }

        [Fact]
        public void HeroCanTakeDamage()
        {
            var hero = new Hero("JoJo");

            hero.Health -= 5;

            Assert.Equal(95, hero.Health);
        }

        [Fact]
        public void HeroCanGetPaid()
        {
            var hero = new Hero("JoJo");

            hero.Gold += 5;

            Assert.Equal(5, hero.Gold);
        }


    }
}
