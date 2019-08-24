using System;
namespace SwordAndBored
{
    public abstract class Character
    {

        public string Name { get; set; }
        public int Attack { get; set; } = 1;
        public int Defense { get; set; } = 0;
        public int Level { get; set; } = 1;
        public int Health { get; set; } = 100;

        public abstract void Stats();
        public abstract void Death();
    }
}
