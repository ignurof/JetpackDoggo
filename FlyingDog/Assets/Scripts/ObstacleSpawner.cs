using System.Collections;
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
    
    // Start is called before the first frame update
    void Start()
    {
        bottomPos = bottomSpawner.gameObject.transform.position;
        topPos = topSpawner.gameObject.transform.position;
        waitingSpawn = true;
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
                Instantiate(prefab, bottomPos, Quaternion.Euler(0, 0, 0));
                break;
            case 2:
                Instantiate(prefab, topPos, Quaternion.Euler(0, 0, 0));
                break;
        }
        yield return new WaitForSeconds(1);
        waitingSpawn = true;
    }
}
