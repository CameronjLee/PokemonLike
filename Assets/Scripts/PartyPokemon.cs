using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyPokemon : MonoBehaviour
{
    public List<PokemonController> party;

    void Start()
    {
        party = new List<PokemonController>();
        party.Add(new PokemonController(((int)Random.Range(1.0f, 1025.0f)).ToString()));
    }

    void AddPokemonToParty(PokemonController newPokemon)
    {
        party.Add(newPokemon);
    }
}
