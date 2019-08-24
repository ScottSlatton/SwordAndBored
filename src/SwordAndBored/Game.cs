using System;
using static System.Environment;

namespace SwordAndBored
{
    public class Game
    {

        public Hero Player;

        public void StartGame()
        {
            StartMenu();
            // CreateLevel(1);
            Console.WriteLine("Press any button to end the adventure.");
            Console.ReadLine();

        }

        private void CreateLevel(int difficulty)
        {
            Level newLevel = new Level(difficulty);
            Console.WriteLine($"You are now entering the Town of {newLevel.Name} ");
        }

        void Exit()
        {
            //TODO: Add save method.
            Console.WriteLine("See you next time, space cowboy.");
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);

        }

        void StartMenu()
        {
            //TODO: Add Continue Option to load from save.
            Console.Clear();
            Console.WriteLine("1. New Game\n");
            Console.WriteLine("2. Exit Game.\n");

            var choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Intro();
            }
            else
            {
                Exit();
            }
        }


        void Intro()
        {

            //Intro for a New Game
            Console.Clear();
            Console.WriteLine("Your eyes open weakly. Your head throbs.\n");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("You wake to the sound of crashing waves and seagulls.\n");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\"Holy shit you're alive.\"\n");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("You look up, to see a gruffy and gray-haired man.\n");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\"Lets get you up, dirt eater.\"\n");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\"I can't be calling you that.\"\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("What's your name?\n");
            CreateHero(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"Well, {Player.Name} glad to see you're alive.\n");

        }
        void CreateHero(string name)
        {

            if (name == "")
            {
                Player = new Hero("Dirt-Eater");
                Console.Clear();
                Console.WriteLine("Silent type eh?\n");
            }
            else
            {
                Player = new Hero(name);
            }
        }
    }
}
