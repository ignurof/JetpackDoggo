using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public string position;

    private int destroyTime = 9;

    private float speed = 10;

    private void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        switch (position)
        {
            case "bot":
                transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
                break;
            case "top":
                transform.Translate(1 * speed * Time.deltaTime, 0, 0);
                break;
        }
    }
}
