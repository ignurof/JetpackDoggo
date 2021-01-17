using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public string position;

    private void Start()
    {
        switch (position)
        {
            case "bot":
                Destroy(gameObject, 5);
                break;
            case "top":
                transform.Rotate(0, 0, -180);
                Destroy(gameObject, 5);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (position)
        {
            case "bot":
                transform.Translate(-1 * 6 * Time.deltaTime, 0, 0);
                break;
            case "top":
                transform.Translate(1 * 6 * Time.deltaTime, 0, 0);
                break;
        }
    }
}
