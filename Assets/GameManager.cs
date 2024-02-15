using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [Header("Debug")]
    public bool debug;
    [SerializeField] int enemyCount;

    [Header("Containers")]
    [SerializeField] Transform enemyHolder;

    [Header("Spawn")]
    public GameObject enemyPrefab;

    [Header("Player")]
    public PlayerScript player;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy(string name = "Enemy")
    {
        var enemy = Instantiate(enemyPrefab, enemyHolder);
        enemy.name = name;
        var range = 100;
        var x = Random.Range(-range, range);
        var y = Random.Range(-range, range);

        var spawnPos = new Vector3(player.transform.position.x + x, player.transform.position.y + y, player.transform.position.z);
        enemy.transform.position = spawnPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
