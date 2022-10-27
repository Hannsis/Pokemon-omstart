using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_omstart;

public class StarterPokemon
{    
    public string? Pokemon { get; set; }
    public string? Name { get; set; }
    public int HP { get; set; }
    public int MaxHP { get; set;}
    public int Attack { get; set; }
    public int MaxAttack { get; set; }
    public int Exp { get; set; }
    public int ExpRequired { get; set; } 
    public int Level { get; set; }
    public int Defence { get; set; }
    public double Gold { get; set; }
}


public class Bulbasaur : StarterPokemon
{
    public Bulbasaur()
    {
        Pokemon = "Bulbasaur";
        Name = "";
        Level = 1;
        HP = 50;
        MaxHP = 50 * Level;
        Attack = 49;
        MaxAttack = 49;
        Defence = 49;
        Gold = 0;
        Exp = 0;
        ExpRequired = 50;
    }
}

public class Squirtle : StarterPokemon
{
    public Squirtle()
    {
        Pokemon = "Squirtle";
        Name = "";
        Level = 1;
        HP = 50;
        MaxHP = 50 * Level;
        MaxAttack = 48;
        Attack = 48;
        Defence = 65;
        Gold = 0;
        Exp = 0;
        ExpRequired = 50;
    } 
}

public class Charmander : StarterPokemon
{
    public Charmander()
    {
        Pokemon = "Charmander";
        Name = "";
        Level = 1;
        HP = 50;
        MaxHP = 50 * Level;
        Attack = 52;
        MaxAttack = 52;
        Defence = 43;
        Gold = 0;
        Exp = 0;
        ExpRequired = 50;
    }
}


