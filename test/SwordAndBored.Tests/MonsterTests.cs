using System;
using Xunit;

namespace SwordAndBored.Tests
{
    public class MonsterTests
    {
        [Fact]
        public void MonsterHasANameAndBaseStats()
        {
            var monster = new Monster(1);

            Assert.Equal("Luciferoth", monster.Name);
            Assert.Equal(1, monster.Speed);
            Assert.Equal(0, monster.Defense);
            Assert.Equal(1, monster.Attack);
            Assert.Equal(1, monster.Level);
            Assert.Equal(100, monster.Health);

        }

        [Fact]
        public void MonsterCanTakeDamage()
        {
            var monster = new Monster(1);

            monster.Health -= 5;

            Assert.Equal(95, monster.Health);
        }


    }
}
