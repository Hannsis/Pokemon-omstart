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
            Console.WriteLine("Welcome to the pokemoncenter! We are here to heal your pokemon! <3 ");
            Console.WriteLine("Here is your pokemon back with perfect health <3");
            Console.WriteLine("See you soon.");

        }

        public void PokemonCenter(StarterPokemon pokemonChoice, Bulbasaur bulbasaur, Charmander charmander, Squirtle squirtle)

        {
            if (pokeChoice == 1)//bulbasaur
            {
                bulbasaur.HP = 45;
            }
            else if (pokeChoice == 2)//Charmander
            {
                charmander.HP = 39;
            }
            else if (pokeChoice == 3)//squirtle
            {
                squirtle.HP = 44;
            }
        }
    }


}
