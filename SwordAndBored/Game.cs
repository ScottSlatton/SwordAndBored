using System;
namespace SwordAndBored
{
    public class Game
    { 

        public void StartGame()
        {
            Console.WriteLine("Hello Adventurer! Welcome to the kingdom of Boredom");
            Console.WriteLine("Please Enter the name of your hero: ");
            Hero player = new Hero(Console.ReadLine());
            Console.WriteLine($"Ah yes, your name is {player.Name} ");
            player.PlayerStats();

        }
    }
}
