using System;
using static System.Environment;

namespace SwordAndBored
{
    public class Game
    { 

        public void StartGame()
        {
            Intro();
            CreateLevel(1);

        }

        private void CreateLevel(int difficulty)
        {
            Level newLevel = new Level(difficulty);
            Console.WriteLine($"You are now entering the Town of {newLevel.Name} ");
        }

        public void Exit()
        {
            //TODO: Add save method.
            Console.WriteLine("See you next time, space cowboy.");
            
        }

 
        void Intro()
        {
            Console.WriteLine("Hello Adventurer! Welcome to the kingdom of Boredom");
            Console.WriteLine("Please Enter the name of your hero: ");
            Hero player = new Hero(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Ah yes, your name is {player.Name} ");
            player.Stats();
        }
    }
}
