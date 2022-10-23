using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_omstart
{
    public class Combat
    {
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
                wildPokemon.Attack = randomAttack.Next(0, 20);
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
                trainer.Attack = randomAttack.Next(0, 20);
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

                }
                if (pokemonChoice.HP <= 0)
                {
                    Console.WriteLine("Your pokemon fainted, you lost the game!");
                    Console.WriteLine();
                    Environment.Exit(0);
                }
                else if (trainer.HP <= 0)
                {

                    Console.WriteLine("\nOika saker level, exp etc");
                    Console.WriteLine("You won the battle!");
                }
            }
        }
    }
}



