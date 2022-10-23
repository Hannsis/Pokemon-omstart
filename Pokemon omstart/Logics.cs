using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pokemon_omstart
{
    internal class Logics
    {
        private bool Playing = true;

        public void Run()
        {

            Intro();
            var pokemonChoice = ChoosePokemon();

            Console.WriteLine("What do you want to name your pokemon?");
            string name = Console.ReadLine();
            pokemonChoice.Name = name;
            Console.WriteLine($"Your pokemon is named {pokemonChoice.Name}\n");

            while (Playing)
            {
                MainMenuChoice(pokemonChoice);
            }           
                           

        }

        private void MainMenuChoice(StarterPokemon pokemonChoice)
        {
            MenuAlternatives();
            Console.WriteLine("What would you like to do?");
            string mainMenuChoice = Console.ReadLine();

            switch (mainMenuChoice)
            {
                case "1":
                    {
                       WildGrass(pokemonChoice);
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("Details about pokemon coming soon!");
                        PlayerStats(pokemonChoice);
                        Console.ReadKey();
                    }
                    break;
                case "3":
                    {
                        Console.WriteLine("welcome to the pokemart! ");
                        Console.ReadKey();

                    }
                    break;
                case "4":
                    {
                        Pokecenter.PokemoncenterWelcome();

                        Pokecenter.PokemonCenter(pokemonChoice, bulbasaur, charmander, squirtle);
                    
                    }
                    break;
                case "5":
                default:
                    Environment.Exit(0);                
                        break;

            }
        }

        public void Intro()
        {
            Console.WriteLine("Welcome to the world of pokémon!" +
                "\nIt's dangerous to wander in the tall grass alone, you need a pokemon with you. " +
                "\nCome with me and chose your pokemon! \n" +
                "\nHere are the starter pokemon you can choose between: \n");
            InfoPokemon();
        }

        public void MenuAlternatives()
        {
            //Console.Clear();
            Console.WriteLine("\nWelcome traveller! To Cerulean City! What would you like to do here?");
             
            Console.WriteLine("1. The tall grass has wild pokemon in it! Do you want to go there?");
            Console.WriteLine("2. Show details about your pokemon.");
            Console.WriteLine("3. Visit the pokémart.");
            Console.WriteLine("4. Quit game.");

        }

        public void PlayerStats(StarterPokemon starterPokemon)
        {
            Console.WriteLine($"Your starter pokemon is: {starterPokemon.Pokemon}");
            Console.WriteLine($"You've named your pokemon: {starterPokemon.Name}");
            Console.WriteLine($"Your pokemon is level: {starterPokemon.Level}");
            Console.WriteLine($"Your pokemon has {starterPokemon.HP} HP");
            Console.WriteLine($"Your pokemon has {starterPokemon.Exp} Exp");

            //Console.WriteLine($"Your pokemon has {StarterPokemon.}"); strength                 ----- shop
            //Console.WriteLine($"Your pokemon has {StarterPokemon.}"); toughness                ----- shop
        }


        public void InfoPokemon()
        {
            Console.WriteLine(

                   $"\n\n1. Bulbasaur is a grass type pokémon," +
                   $" its attacks are: " +
                   $"\ntackle \nleech seed \nvine whip \nand growl!" +
                   $"\n\n2. Charmander is a fire type pokémon, " +
                   $"its attacks are: " +
                   $"\ngrowl \nscratch \nember \nand leer!" +
                   $"\n\n3. Squirtle is a water type pokémon," +
                   $" And it's attacks are: " +
                   $"\nTackle, \nwatergun, \ntailwhip \nand bubble!\n");
        }

        public StarterPokemon ChoosePokemon()
        {
            Console.WriteLine("Which pokemon do you choose?");
            string pokemonChoice = Console.ReadLine();

            switch (pokemonChoice)
            {
                case "1":
                    {
                        Pokecenter.pokeChoice = 1;
                        Console.Clear();
                        Bulbasaur bulbasaur = new Bulbasaur();
                        Console.WriteLine($"You have chosen {bulbasaur.Pokemon}");
                        return bulbasaur;

                    }
                case "2":
                    {
                        Pokecenter.pokeChoice = 2;
                        Console.Clear();
                        Charmander charmander = new Charmander();
                        Console.WriteLine($"You have chosen {charmander.Pokemon}");
                        return charmander;
                    }
                case "3":
                    {
                        Pokecenter.pokeChoice = 3;
                        Console.Clear();
                        Squirtle squirtle = new Squirtle();
                        Console.WriteLine($"You have chosen {squirtle.Pokemon}");
                        return squirtle;
                    }
                default:
                    return ChoosePokemon();

            }
        }

        public void WildGrass(StarterPokemon pokemonChoice)
        {
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



    }

}
