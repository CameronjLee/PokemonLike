using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonController : Pokemon
{
    PokemonBaseStats baseStats;

    public PokemonController(string pokemonId)
    {
        baseStats = new PokemonBaseStats(pokemonId);
        PokemonStats stats = new PokemonStats(pokemonId, baseStats);
        Name = stats.name;
        HealthStat = stats.healthStat;
        AttackStat = stats.attackStat;
        DefenceStat = stats.defenceStat;
        SpecialAttackStat = stats.specialAttackStat;
        SpecialDefenceStat = stats.specialDefenceStat;
        SpeedStat = stats.speedStat;

    }
}
