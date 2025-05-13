using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BattleSceneController : MonoBehaviour
{
    //public GameObject enemySpawn;
    public PokemonStats enemyPokemon;
    private Sprite sprite;
    private Texture2D texture;
    private SpriteRenderer spriteRenderer;

    public string name;
    public int healthStat;
    public int attackStat;
    public int defenceStat;
    public int specialAttackStat;
    public int specialDefenceStat;
    public int speedStat;

    void Awake()
    {
        spriteRenderer = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
    }

    //now that I've worked out how this works I probably want to convert this to being called something else. Similar idea needs to be implemented for the other side
    void Start()
    {
        enemyPokemon = new PokemonStats(((int)Random.Range(1.0f, 1025.0f)).ToString());
        //enemyPokemon = gameObject.AddComponent<PokemonStats>();

        name = enemyPokemon.name;
        healthStat = enemyPokemon.healthStat;
        attackStat = enemyPokemon.attackStat;
        defenceStat = enemyPokemon.defenceStat;
        specialAttackStat = enemyPokemon.specialAttackStat;
        specialDefenceStat = enemyPokemon.specialDefenceStat;
        speedStat = enemyPokemon.speedStat;

        texture = (Texture2D)AssetDatabase.LoadAssetAtPath($"Assets/Textures/{name}.png", typeof(Texture2D));
        sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 60.0f);
        spriteRenderer.sprite = sprite;
    }
}
