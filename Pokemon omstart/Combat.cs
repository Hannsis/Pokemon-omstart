using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_omstart;

public class Combat
{
    public static void WildGrass(StarterPokemon pokemonChoice)
    {
        Console.Clear();
      //  Console.ReadKey();

        Random random = new Random();
        int Spawn = random.Next(0, 9);

        if (Spawn == 2 && pokemonChoice.Level >= 5 || Spawn == 3 && pokemonChoice.Level >= 5)
        //if(spawn == 2 || spawn == 2 && pokemonChoice.Level == 5 || spawn == 3 && pokemonChoice.Level == 5)
        {
            Combat combat = new Combat();
            Console.WriteLine("\nThere is a russle in the grass, prepare for battle!");
            Console.WriteLine("A trainer was hiding in the grass and wants to fight! Prepare for battle!");
            combat.BattleTrainer(pokemonChoice);
        }
        else if (Spawn == 1)//return to SpelomgångMenu
        {
            Console.WriteLine("\nThe grass sways peacefully and nothing happened.\n");
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
        // Polymorfism! 
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
            Console.WriteLine($"\nThe {wildPokemon.Pokemon} makes it move!");
            Console.WriteLine("Press enter to attack");
            Console.WriteLine();

            var choice = ConsoleKey.Enter;
            if (choice == Console.ReadKey().Key)
            {
                Random randomAttack = new Random();
                wildPokemon.Attack = randomAttack.Next(0, wildPokemon.MaxAttack);
                pokemonChoice.Attack = randomAttack.Next(0, pokemonChoice.MaxAttack);


                Console.WriteLine($"The {wildPokemon.Pokemon} attacked for {wildPokemon.Attack} damage!");

                pokemonChoice.HP = pokemonChoice.HP - wildPokemon.Attack;
                Console.WriteLine($"Your {pokemonChoice.Name} has {pokemonChoice.HP} HP left\n");

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
        else if (wildPokemon.HP <= 0)// Risk finns att spelarna blir ledsna :).
        {

            Console.WriteLine("You won the battle!\n");

            Random randomGold = new Random();
            var gold = randomGold.Next(1, 10);//For gold
            Console.WriteLine($"You've deafeated the wild pokemon, you see something shiny on the ground. You found {gold} gold!");
            pokemonChoice.Gold += gold;

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
            trainer.Attack = randomAttack.Next(0, trainer.MaxAttack);
            pokemonChoice.Attack = randomAttack.Next(0, pokemonChoice.MaxAttack);

            Console.WriteLine($"\nThe trainer sends out it's {trainer.Pokemon}!");
            Console.WriteLine("Press enter to attack");
            Console.WriteLine();

            var choice = ConsoleKey.Enter;
            if (choice == Console.ReadKey().Key)
            {

                Console.WriteLine($"The {trainer.Pokemon} attacked for {trainer.Attack} damage!");
                pokemonChoice.HP = pokemonChoice.HP - trainer.Attack;
                Console.WriteLine($"Your {pokemonChoice.Name} has {pokemonChoice.HP} HP left\n");


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
                var gold = randomGold.Next(1, 100);//For gold
                Console.WriteLine($"You've deafeated the trainer and gotten {gold} gold for winning!");
                pokemonChoice.Gold += gold;
                LevelingUp(pokemonChoice);
            }
        }
    }

    public static void LevelingUp(StarterPokemon pokemonChoice)

    {
        Random randomExp = new Random();
        int expWon = randomExp.Next(1, 100);

        pokemonChoice.Exp += expWon;

        Console.WriteLine($"{expWon} won exp");
        Console.WriteLine($"{pokemonChoice.Exp} current exp");

        Console.WriteLine($"{pokemonChoice.Level} pokemon level");

        if (pokemonChoice.Level == 10)
        {
            Console.WriteLine($"Congratulations! You have reached level {pokemonChoice.Level} and won the game!  ");
            Environment.Exit(0);
        }

        if (pokemonChoice.Exp > pokemonChoice.ExpRequired)
        {
            pokemonChoice.Level++;
            pokemonChoice.Exp = 0;
            pokemonChoice.ExpRequired = 50 * pokemonChoice.Level;
            Console.WriteLine($"Your pokemon leveled up! Your pokemon is level {pokemonChoice.Level}");
            Console.WriteLine($"{pokemonChoice.Exp} current exp");
            Console.WriteLine($"{pokemonChoice.Level} pokemon level");
        }
        Console.ReadLine();
    }
}



