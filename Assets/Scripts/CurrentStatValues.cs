using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentStatValues
{
    public Pokemon CurrentStats;

    public CurrentStatValues(Pokemon baseStats)
    {
        Pokemon currentStats = baseStats;
        //int ivs = 24;
        Dictionary<String, int> ivs = new Dictionary<String, int>()
        {
            { "HP", 24  },
            { "Attack", 12 },
            { "Defence", 30 },
            { "SpecialAttack", 16 },
            { "SpecialDefence", 23 },
            { "Speed", 5 }
        };
        Dictionary<String, int> evs = new Dictionary<String, int>()
        {
            { "HP", 74  },
            { "Attack", 190 },
            { "Defence", 91 },
            { "SpecialAttack", 48 },
            { "SpecialDefence", 84 },
            { "Speed", 23 }
        };
        Dictionary<String, double> nature = new Dictionary<String, double>()
        {
            { "Attack", 1.1 },
            { "Defence", 1.0 },
            { "SpecialAttack", 0.9 },
            { "SpecialDefence", 1.0 },
            { "Speed", 1.0 }
        };

        currentStats.HealthStat = (int)Math.Floor((double)((2 * currentStats.HealthStat + ivs["HP"] + ((int)Math.Floor((double)evs["HP"] / 4))) * currentStats.Level / 100)) + 78 + 10;
        currentStats.AttackStat = (int)Math.Floor(((int)Math.Floor((double)((2 * currentStats.AttackStat + ivs["Attack"] + ((int)Math.Floor((double)evs["Attack"] / 4))) * currentStats.Level / 100)) + 5) * nature["Attack"]);
        currentStats.DefenceStat = (int)Math.Floor(((int)Math.Floor((double)((2 * currentStats.DefenceStat + ivs["Defence"] + ((int)Math.Floor((double)evs["Defence"] / 4))) * currentStats.Level / 100)) + 5) * nature["Defence"]);
        currentStats.SpecialAttackStat = (int)Math.Floor(((int)Math.Floor((double)((2 * currentStats.SpecialAttackStat + ivs["SpecialAttack"] + ((int)Math.Floor((double)evs["SpecialAttack"] / 4))) * currentStats.Level / 100)) + 5) * nature["SpecialAttack"]);
        currentStats.SpecialDefenceStat = (int)Math.Floor(((int)Math.Floor((double)((2 * currentStats.SpecialDefenceStat + ivs["SpecialDefence"] + ((int)Math.Floor((double)evs["SpecialDefence"] / 4))) * currentStats.Level / 100)) + 5) * nature["SpecialDefence"]);
        currentStats.SpeedStat = (int)Math.Floor(((int)Math.Floor((double)((2 * currentStats.SpeedStat + ivs["Speed"] + ((int)Math.Floor((double)evs["Speed"] / 4))) * currentStats.Level / 100)) + 5) * nature["Speed"]);

        CurrentStats = currentStats;
    }
}
