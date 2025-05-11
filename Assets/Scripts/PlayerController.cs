using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //https://www.youtube.com/watch?v=YnwOoxtgZQI

    [SerializeField]
    private Tilemap groundTilemap;
    [SerializeField]
    private Tilemap collisionTilemap;
    [SerializeField]
    private Tilemap grassTile;

    private PlayerMovement controls;

    private void Awake()
    {
        controls = new PlayerMovement();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    void Start()
    {
        controls.Main.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());
    }

    private void Move(Vector2 direction)
    {
        if (CanMove(direction))
        {
            transform.position += (Vector3)direction;
            MovedIntoGrass(transform);
        }            
    }

    private bool CanMove(Vector2 direction)
    {
        Vector3Int gridposition = groundTilemap.WorldToCell(transform.position + (Vector3)direction);

        if(!groundTilemap.HasTile(gridposition) || collisionTilemap.HasTile(gridposition))
            return false;
        return true;
    }

    public void MovedIntoGrass(Transform player)
    {
        Vector3Int gridPosition = groundTilemap.WorldToCell(player.position);

        if (grassTile.HasTile(gridPosition))
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        int spawnChance = (int)Random.Range(0.0f, 100.0f);

        if (spawnChance > 50)
        {
            SceneManager.LoadScene("BattleScene");
        }
    }
}
