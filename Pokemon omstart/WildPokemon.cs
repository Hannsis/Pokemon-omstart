﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_omstart;

public class WildPokemon
{

    public string? Pokemon { get; set; }
    public int HP { get; set; }
    public int Attack { get; set; }
    public int MaxAttack { get; set; }

    public void RandomAttack(int attack)
    {
        Random randomAttack = new Random();
        Attack = randomAttack.Next(0, Attack);

    }

    public void DamageTaken(int damageTaken)
    {
        HP = -damageTaken;
    }
}
public class Rattata : WildPokemon
{
    public Rattata()
    {
        Pokemon = "Rattata";
        HP = 30;
        Attack = 20;
        MaxAttack = 20;
    }
}
public class Pidgey : WildPokemon
{
    public Pidgey()
    {
        Pokemon = "Pidgey";
        HP = 40;
        Attack = 20;
        MaxAttack = 20;
    }

}
public class Spearow : WildPokemon
{
    public Spearow()
    {
        Pokemon = "Spearow";
        HP = 40;
        Attack = 20;
        MaxAttack = 20;
    }
}

