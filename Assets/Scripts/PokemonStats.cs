using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonStats : MonoBehaviour
{
    private readonly PokemonBaseStats baseStats;

    public Pokemon stats;
    public int Id;
    public string name;
    public int healthStat;
    public int attackStat;
    public int defenceStat;
    public int specialAttackStat;
    public int specialDefenceStat;
    public int speedStat;

    public PokemonStats(string pokemonId, PokemonBaseStats baseStatistics)
    {
        baseStats = baseStatistics;
        CurrentStatValues currentStats = new CurrentStatValues(baseStats);
        stats = currentStats.currentStats;

        name = stats.Name;
        healthStat = stats.HealthStat;
        attackStat = stats.AttackStat;
        defenceStat = stats.DefenceStat;
        specialAttackStat = stats.SpecialAttackStat;
        specialDefenceStat = stats.SpecialDefenceStat;
        speedStat = stats.SpeedStat;
        
    }
}
