//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Tilemaps;
//using UnityEngine.SceneManagement;

////https://discussions.unity.com/t/how-to-make-a-spawner/207903/2

//public class GrassSpawner : MonoBehaviour
//{
//    //public GameObject spawner;
//    public Transform player;
//    [SerializeField]
//    private Tilemap groundTilemap;
//    [SerializeField]
//    private Tilemap grassTile;
//    Boolean inBattle;

//    private void Start()
//    {
//        inBattle = false;
//    }

//    // this does load one scene but it has the issue with showing visuals from the below scene and update triggers a potential spawn every frame that the user is
//    //in grass, not when the user moves into gras, then stops

//    void Update()
//    {
//        Vector3Int gridPosition = groundTilemap.WorldToCell(player.position);

//        if (grassTile.HasTile(gridPosition) && !inBattle)
//        {
//            Spawn();
//        }
//    }

//    private void Spawn()
//    {
//        int spawnChance = (int)UnityEngine.Random.Range(0.0f, 100.0f);

//        if (spawnChance > 50)
//        {
//            SceneManager.LoadScene("BattleScene", LoadSceneMode.Additive);
//            //battleSceneController = new BattleSceneController();
//            inBattle = true;
//        }
//    }
//}
