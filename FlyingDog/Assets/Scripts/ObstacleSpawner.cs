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
    
    // Start is called before the first frame update
    void Start()
    {
        bottomPos = bottomSpawner.gameObject.transform.position;
        topPos = topSpawner.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        switch (RandomSpawnerGenerator())
        {
            case 1:
                Instantiate(prefab, bottomPos, Quaternion.Euler(0, 0, 0));
                break;
            case 2:
                Instantiate(prefab, topPos, Quaternion.Euler(0, 0, 0));
                break;
        }
    }

    int RandomSpawnerGenerator()
    {
        int result;
        result = Random.Range(1, 3);
        return result;
    }
}
