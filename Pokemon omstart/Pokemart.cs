using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_omstart;

public class Pokemart
{
    Items items = new Items();
    Defence defence = new Defence();
    AttackPower attackPower = new AttackPower();
    Leveling leveling = new Leveling();

    private double OrderTotal;

    public Pokemart()
    {
        OrderTotal = 0;
    }

    public void RunPokemart()
    {
        //run shop logic
        ShopIntro();

        SellItems(leveling.Name, leveling.Price);
        DisplayOrderTotal(); 
        
        SellItems(attackPower.Name, attackPower.Price);
        DisplayOrderTotal(); 
        
        SellItems(defence.Name, defence.Price);
        DisplayOrderTotal();

        ShopOutro();
    }

    private void ShopIntro() 
    {
        Console.WriteLine("================================");
        Console.WriteLine("*                              *");
        Console.WriteLine("*   Welcome to the Pokemart!   *");
        Console.WriteLine("*                              *");
        Console.WriteLine("================================");
        Console.WriteLine();
        Console.WriteLine("Today we have these items for sale:");
        Console.WriteLine(leveling.Name);
        Console.WriteLine(attackPower.Name);
        Console.WriteLine(defence.Name);
    }

    private void SellItems(string itemName, double cost) 
    {
        Console.WriteLine();
        Console.WriteLine($"We have {itemName} for your pokemon! It costs {cost} gold.");
        Console.WriteLine("Do you like to buy this item? Y/N");
        string response = Console.ReadLine().ToUpper();
        if (response.StartsWith ("Y"))
        {
            
            Console.WriteLine("");
            OrderTotal += cost;
        }
        else 
        {
            Console.WriteLine("Oh well, maybe next time!"); 
        }
    }
    private void DisplayOrderTotal() 
    {
        Console.WriteLine();
        Console.WriteLine($"Your total is: {OrderTotal} gold.");
    }

    private void ShopOutro() 
    {
        Console.WriteLine("Thank you for shopping! Please come again");
        Console.WriteLine("Press enter to exit the shop");
      
    
    }
}

