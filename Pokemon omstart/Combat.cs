﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_omstart
{
    public class Combat
    {
        public static void WildGrass(StarterPokemon pokemonChoice)
        {
            Console.Clear();
            Console.ReadKey();

            Random random = new Random();
            int Spawn = random.Next(0, 9);

            if (Spawn == 1)//return to SpelomgångMenu
            {
                Console.WriteLine("\nThe grass sways peacefully and nothing happened.\n");
            }

            else if (Spawn == 2)
            {
                Combat combat = new Combat();
                Console.WriteLine("\nThere is a russle in the grass, prepare for battle!");
                Console.WriteLine("A trainer was hiding in the grass and wants to fight! Prepare for battle!");
                combat.BattleTrainer(pokemonChoice);
            }

            else
            {
                Combat combat = new Combat();
                Console.WriteLine("\nThere is a russle in the grass!");
                Console.WriteLine("A wild pokemon was hiding in the grass and wants to fight! Prepare for battle!");
                combat.BattleWildPokemon(pokemonChoice);

            }
        }

        public WildPokemon GenerateWildPokemon()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            switch (randomNumber)
            {
                case 0:
                    return new Spearow();
                case 1:
                    return new Pidgey();
                case 2:
                default:
                    return new Rattata();
            }
        }

        public void BattleWildPokemon(StarterPokemon pokemonChoice)
        {
            var wildPokemon = GenerateWildPokemon();

            while (pokemonChoice.HP > 0 && wildPokemon.HP > 0)
            //TODO: validera choice
            {
                Random randomAttack = new Random();
                wildPokemon.Attack = randomAttack.Next(0, 10);
                pokemonChoice.Attack = randomAttack.Next(0, 20);

                Console.WriteLine($"\nThe {wildPokemon.Pokemon} makes it move!");
                Console.WriteLine("Press enter to attack");

                var choice = ConsoleKey.Enter;
                if (choice == Console.ReadKey().Key)
                {
                    Console.WriteLine($"\nYour {pokemonChoice.Name} has {pokemonChoice.HP} HP");
                    Console.WriteLine($"The {wildPokemon.Pokemon} has {wildPokemon.HP} HP\n");

                    Console.WriteLine($"The {wildPokemon.Pokemon} attacked for {wildPokemon.Attack} damage!");
                    pokemonChoice.HP = pokemonChoice.HP - wildPokemon.Attack;
                    Console.WriteLine($"Your {pokemonChoice.Name} has {pokemonChoice.HP} HP left\n");

                    //Console.WriteLine($"The wild {wildPokemon.Pokemon} has {wildPokemon.HP} HP");
                    Console.WriteLine($"{pokemonChoice.Name} attacked for {pokemonChoice.Attack} damage!");
                    wildPokemon.HP = wildPokemon.HP - pokemonChoice.Attack; //-=
                    Console.WriteLine($"The {wildPokemon.Pokemon} has {wildPokemon.HP} HP");

                    Console.ReadKey();
                    Console.Clear();
                }
            }
            if (pokemonChoice.HP <= 0)
            {
                Console.WriteLine("Your pokemon fainted, you lost the game!");
                Console.WriteLine();
                Environment.Exit(0);
            }
            else if (wildPokemon.HP <= 0)
            {

                Console.WriteLine("\nOika saker level, exp etc");
                Console.WriteLine("You won the battle!\n");
                LevelingUp(pokemonChoice);
            }
        }

        public StarterPokemon GenerateTrainer()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            switch (randomNumber)
            {
                case 0:
                    return new Bulbasaur();
                case 1:
                    return new Charmander();
                case 2:
                default:
                    return new Squirtle();
            }
        }

        public void BattleTrainer(StarterPokemon pokemonChoice)
        {
            var trainer = GenerateTrainer();

            while (pokemonChoice.HP > 0 && trainer.HP > 0)
            //TODO: validera choice
            {
                Random randomAttack = new Random();
                trainer.Attack = randomAttack.Next(0, 10);
                pokemonChoice.Attack = randomAttack.Next(0, 20);

                Console.WriteLine($"\nThe {trainer.Pokemon} makes it move!");
                Console.WriteLine("Press enter to attack");

                //string choice = Console.ReadLine();
                var choice = ConsoleKey.Enter;
                if (choice == Console.ReadKey().Key)
                {
                    Console.WriteLine($"\nYour {pokemonChoice.Name} has {pokemonChoice.HP} HP");
                    Console.WriteLine($"The {trainer.Pokemon} has {trainer.HP} HP\n");

                    Console.WriteLine($"The {trainer.Pokemon} attacked for {trainer.Attack} damage!");
                    pokemonChoice.HP = pokemonChoice.HP - trainer.Attack;
                    Console.WriteLine($"Your {pokemonChoice.Name} has {pokemonChoice.HP} HP left\n");

                    //Console.WriteLine($"The wild {wildPokemon.Pokemon} has {wildPokemon.HP} HP");
                    Console.WriteLine($"{pokemonChoice.Name} attacked for {pokemonChoice.Attack} damage!");
                    trainer.HP = trainer.HP - pokemonChoice.Attack; //-=
                    Console.WriteLine($"The {trainer.Pokemon} has {trainer.HP} HP");

                    Console.ReadKey();
                    Console.Clear();

                }
                if (pokemonChoice.HP <= 0)
                {
                    Console.WriteLine("Your pokemon fainted, you lost the game!");
                    Console.WriteLine();
                    Environment.Exit(0);
                }
                else if (trainer.HP <= 0)
                {                                       
                    Console.WriteLine("You won the battle!");
                    Random randomGold = new Random();
                    var gold = randomGold.Next(1, 20);//For gold
                    Console.WriteLine($"You've deafeated the trainer and gotten {gold} gold for winning!");
                    pokemonChoice.Gold = gold;
                    LevelingUp(pokemonChoice);
                }
            }
        }

        public static void LevelingUp(StarterPokemon pokemonChoice)
            //it resets after every battle, return? 
        {
            Random randomExp = new Random();
            int expWon = randomExp.Next(1, 100);
            int currentExp = pokemonChoice.Exp;

            pokemonChoice.Exp = currentExp + expWon;
            int level = pokemonChoice.Level;

            int expRequired = 100;

            Console.WriteLine($"{expWon} won exp");
            Console.WriteLine($"{pokemonChoice.Exp} current exp");

            Console.WriteLine($"{level} level");
            Console.WriteLine($"{pokemonChoice.Level} pokemon level");

            if (currentExp > expRequired)
            {
                pokemonChoice.Level++;
                pokemonChoice.HP += 20;
                currentExp -= expRequired;
                expRequired = expRequired + 100;
                Console.WriteLine($"Your pokemon leveled up! You now have {pokemonChoice.Exp}");
                Console.WriteLine($"{currentExp} current exp");
                Console.WriteLine($"{level} level");
                Console.WriteLine($"{pokemonChoice.Level} pokemon level");
            }

        }
    }
}



