﻿using System;
using System.Collections.Generic;
namespace SwordAndBored
{
    public class Level
    {
        public string Name { get; set; }
        private int monsterSeed;
        private List<Monster> monsters;

        public Level(int difficulty)
        {
            SetLevel(difficulty);
            SpawnMonsters(difficulty);
        }

        private void SetLevel(int difficulty)
        {
            switch (difficulty)
            {
                case 1:
                    Name = "Pallet";
                    break;
                case 2:
                    Name = "Lavender";
                    break;
                case 3:
                    Name = "Kaos";
                    break;
                default:
                    Name = "Abyss";
                    break;

            }
        }

        public void SpawnMonsters(int difficulty)
        {

            monsterSeed = RandomNumber(0, 3) + difficulty;
            
            for (int i = 0; i < monsterSeed; i++)
            {
                monsters[i] = new Monster(difficulty);
                Console.WriteLine($"A new monster has spawned in {this.Name}");

            }

        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);

        }
    }
}
