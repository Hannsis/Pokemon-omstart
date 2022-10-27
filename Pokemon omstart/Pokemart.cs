using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_omstart;

public class Pokemart
{
    Defence defence = new Defence();
    AttackPower attackPower = new AttackPower();
    Leveling leveling = new Leveling();

    private int OrderTotal;

    public Pokemart()
    {
        OrderTotal = 0;
    }

    public void RunPokemart(StarterPokemon pokemonChoice, Items XRareCandy, Items xAttack, Items xDefence)
    {
        //run shop logic
        ShopIntro(pokemonChoice);

        SellItems(pokemonChoice, attackPower, defence, leveling);

        DisplayOrderTotal();

        ShopOutro();

    }

    private void ShopIntro(StarterPokemon pokemonChoice)
    {
        OrderTotal = 0;
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("*                              *");
        Console.WriteLine("*   Welcome to the Pokemart!   *");
        Console.WriteLine("*                              *");
        Console.WriteLine("================================");
        Console.WriteLine();
        Console.WriteLine("Today we have these items for sale:");
        Console.WriteLine($"1. {leveling.Name}:  {leveling.Description}. \nPrice: {leveling.Price}\n");
        Console.WriteLine($"2. {attackPower.Name}: {attackPower.Description}. \nPrice: {attackPower.Price}\n");
        Console.WriteLine($"3. {defence.Name}: {defence.Description}. \nPrice: {defence.Price}\n");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"You have {pokemonChoice.Gold} gold in your wallet");
    }

    private void SellItems(StarterPokemon pokemonChoice, AttackPower xAttack, Defence xDefence, Leveling xRareCandy)
    {
     
        Console.WriteLine("What do you want to buy:");
        string ShopIntroChoice = Console.ReadLine();

        switch (ShopIntroChoice)
        {
            case "1":
                if (pokemonChoice.Gold >= xRareCandy.Price)
                {
                    OrderTotal += xRareCandy.Price;
                    ApplyRareCandy(pokemonChoice);
                    Console.WriteLine($"You've$ bought a rare candy! Your pokemon has grown to level: {pokemonChoice.Level}");
                    pokemonChoice.Gold -= xRareCandy.Price;

                    if (pokemonChoice.Level == 10)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Congratulations! You have reached level {pokemonChoice.Level} and won the game!  ");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient funds! ");
                    break;
                }
                break;

            case "2":
                if (pokemonChoice.Gold >= xAttack.Price)
                {
                    OrderTotal += xAttack.Price;
                    ApplyAttack(pokemonChoice);
                    Console.WriteLine($"You've bought X-attack! Your pokemons Attackpower went up to: {pokemonChoice.MaxAttack}");
                    pokemonChoice.Gold -= xAttack.Price;
                }
                else
                {
                    Console.WriteLine("Insufficient funds! ");
                    break;
                }
                break;
            case "3":
                if (pokemonChoice.Gold >= xDefence.Price)
                {
                    OrderTotal += xDefence.Price;
                    ApplyDefence(pokemonChoice);
                    Console.WriteLine("You've bought X-defence! Your pokemons defences went up!");
                    pokemonChoice.Gold -= xDefence.Price;
                }
                else
                {
                    Console.WriteLine("Insufficient funds! ");
                    break;
                }
                break;
            default:
                break;
        }
    }

    private void ApplyRareCandy(StarterPokemon pokemonChoice)
    {
        pokemonChoice.Level++;
    }
    private void ApplyAttack(StarterPokemon pokemonChoice)
    {
        pokemonChoice.MaxAttack += 10;
    }
    private void ApplyDefence(StarterPokemon pokemonChoice)
    {
        pokemonChoice.Defence += 10;
    }

    private void DisplayOrderTotal()
    {
        Console.WriteLine();
        Console.WriteLine($"The total cost is: {OrderTotal} gold.");
    }

    private void ShopOutro()
    {
        Console.WriteLine("Thank you for shopping! Please come again");
        Console.WriteLine("Press enter to exit the shop");

    }


}

