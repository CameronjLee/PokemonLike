using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BattleSceneController : MonoBehaviour
{
    public GameObject enemySpawn;
    public GameObject partySpawn;
    //public GameObject player;

    private Sprite sprite;
    private Texture2D texture;
    private SpriteRenderer enemySpriteRenderer;
    private SpriteRenderer partySpriteRenderer;

    void Awake()
    {
        enemySpriteRenderer = enemySpawn.AddComponent<SpriteRenderer>();
        partySpriteRenderer = partySpawn.AddComponent<SpriteRenderer>();
    }

    //now that I've worked out how this works I probably want to convert this to being called something else. Similar idea needs to be implemented for the other side
    void Start()
    {
        Pokemon enemyPokemon = new PokemonController(((int)Random.Range(1.0f, 1025.0f)).ToString());
        //Pokemon partyPokemon = player.GetComponent<PartyPokemon>().party[0];

        texture = (Texture2D)Resources.Load($"Textures/{enemyPokemon.Name}", typeof(Texture2D));
        sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 60.0f);
        enemySpriteRenderer.sprite = sprite;

        //texture = (Texture2D)Resources.Load($"Assets/Textures/{partyPokemon.name}.png", typeof(Texture2D));
        //sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 60.0f);
        //partySpriteRenderer.sprite = sprite;
    }
}
