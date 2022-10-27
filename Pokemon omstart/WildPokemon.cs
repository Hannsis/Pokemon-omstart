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
}

public class Rattata : WildPokemon
{
    public Rattata()
    {
        Pokemon = "Rattata";
        HP = 30;
        Attack = 30;
        MaxAttack = 30;
    }
}

public class Pidgey : WildPokemon
{
    public Pidgey()
    {
        Pokemon = "Pidgey";
        HP = 40;
        Attack = 30;
        MaxAttack = 30;
    }
}

public class Spearow : WildPokemon
{
    public Spearow()
    {
        Pokemon = "Spearow";
        HP = 40;
        Attack = 40;
        MaxAttack = 40;
    }
}

