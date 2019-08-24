using System;
namespace SwordAndBored
{
    public class Hero : Character
    {


        public Hero(string name)
        {
            Name = name;
        }

        public override void Stats()
        {
            Console.WriteLine($"Player Name: {Name}");
            Console.WriteLine($"Current Level: {Level}");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Defense: {Defense}");
        }
        public override void Death()
        {
            if (this.Health == 0)
            {
                Console.WriteLine($"You Have Died");
            }
        }

        public void EquipWeapon()
        {
            Attack += 5;
        }
    }
}
