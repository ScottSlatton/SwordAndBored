using System;
namespace SwordAndBored
{
    public class Hero
    {
  
        public string Name { get; set; }
        public int Attack { get; set; } = 1;
        public int Defense { get; set; } = 0;
        public int Level { get; set; } = 1;

        public Hero(string name)
        {
            this.Name = name;
        }

        public void PlayerStats()
        {
            Console.WriteLine($"Player Name: {Name}");
            Console.WriteLine($"Current Level: {Level}");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Defense: {Defense}");
        }
    }
}
