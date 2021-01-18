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
        switch (position)
        {
            case "bot":
                Destroy(gameObject, destroyTime);
                break;
            case "top":
                transform.Rotate(0, 0, -180);
                Destroy(gameObject, destroyTime);
                break;
        }
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
