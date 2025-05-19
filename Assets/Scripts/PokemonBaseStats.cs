using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class PokemonBaseStats : Pokemon
{

    public PokemonBaseStats(string pokemonId)
    {
        string path = Path.Combine(Application.streamingAssetsPath, "Pokemon_JSON_v2.txt");
        string jsonText = File.ReadAllText(path);
        Dictionary<string, Dictionary<string, string>> json = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(jsonText);

        
        Name = json[pokemonId.ToLower()]["name"];
        HealthStat = int.Parse(json[pokemonId.ToLower()]["hp"]);
        AttackStat = int.Parse(json[pokemonId.ToLower()]["attack"]);
        DefenceStat = int.Parse(json[pokemonId.ToLower()]["defense"]);
        SpecialAttackStat = int.Parse(json[pokemonId.ToLower()]["special-attack"]);
        SpecialDefenceStat = int.Parse(json[pokemonId.ToLower()]["special-defense"]);
        SpeedStat = int.Parse(json[pokemonId.ToLower()]["speed"]);
        Level = 78;
        
    }
}
