﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject bottomSpawner;
    public GameObject topSpawner;
    public GameObject prefab;
    private Vector3 bottomPos;
    private Vector3 topPos;

    private bool waitingSpawn;

    // Limit spawn amounts per position
    private int botAmount;
    private int topAmount;
    
    // Start is called before the first frame update
    void Start()
    {
        bottomPos = bottomSpawner.gameObject.transform.position;
        topPos = topSpawner.gameObject.transform.position;
        waitingSpawn = true;
        botAmount = 0;
        topAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Check the random result and spawn obstacle
        if (waitingSpawn)
            StartCoroutine(RandomSpawnerGenerator());
    }

    // Spawn Timer
    IEnumerator RandomSpawnerGenerator()
    {
        waitingSpawn = false;
        int result;
        result = Random.Range(1, 3);

        switch (result)
        {
            case 1:
                if(botAmount >= 1)
                {
                    Instantiate(prefab, topPos, Quaternion.Euler(0, 0, 0));
                    topAmount++;
                    botAmount = 0;
                }
                else
                {
                    Instantiate(prefab, bottomPos, Quaternion.Euler(0, 0, 0));
                    botAmount++;
                }
                break;
            case 2:
                if(topAmount >= 1)
                {
                    Instantiate(prefab, bottomPos, Quaternion.Euler(0, 0, 0));
                    botAmount++;
                    topAmount = 0;
                }
                else
                {
                    Instantiate(prefab, topPos, Quaternion.Euler(0, 0, 0));
                    topAmount++;
                }
                break;
        }
        yield return new WaitForSeconds(1);
        waitingSpawn = true;
    }
}
