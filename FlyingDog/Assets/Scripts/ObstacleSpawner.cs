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
        
    }
}
