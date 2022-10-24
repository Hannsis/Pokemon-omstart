using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_omstart
{
    public class Pokecenter
    {

        public static int pokeChoice { get; set; }

        public static void PokemoncenterWelcome() 
        {
            Console.Clear();

            Console.WriteLine("Welcome to the pokemoncenter! We are here to heal your pokemon! <3 ");
            Console.WriteLine("Here is your pokemon back with perfect health <3");
            Console.WriteLine("See you soon.");
            
            Console.ReadKey();
            Console.Clear();

        }

        public void PokemonCenter(StarterPokemon pokemonChoice, Bulbasaur bulbasaur, Charmander charmander, Squirtle squirtle)

        {
            if (pokeChoice == 1)
            {
                bulbasaur.HP = 45;
                //göra någon slags MaxHP int här
            }
            else if (pokeChoice == 2)
            {
                charmander.HP = 39;
            }
            else if (pokeChoice == 3)
            {
                squirtle.HP = 44;
            }
        }
    }


}
