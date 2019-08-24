using System;
namespace SwordAndBored
{
    public class Monster : Character
    {

        public Monster(int difficulty)
        {
            this.Name = "Luciferoth";
            this.Level = difficulty;
        }
        public override void Death()
        {
            if (this.Health == 0)
            {
                Console.WriteLine($"{this.Name} has been slain.");
            }
        }

        public override void Stats()
        {
            Console.WriteLine($"Monster Name: {Name}");
            Console.WriteLine($"Current Level: {Level}");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Defense: {Defense}");
        }
    }
}
