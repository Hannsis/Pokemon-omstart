using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_omstart;

public class Items

{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int LevelUp { get; set; }
    public int Attack { get; set; }
    public int Defence { get; set; }

}

public class Defence : Items
{
    public Defence()
    {
        Name = "X Defence";
        Description = "This raises your pokemons defences";
        Price = 5;
        Defence = +10;        
    }
}

public class AttackPower : Items
{
    public AttackPower()
    {
        Name = "X Attack";
        Description = "This raises your pokemons attack";
        Price = 5;
        Attack = +10;
    }
}

public class Leveling : Items
{
    public Leveling()
    {
        Name = "Rare Candy";
        Description = "This raises your pokemons level by one";
        Price = 500;
        LevelUp = +1;
    }
}