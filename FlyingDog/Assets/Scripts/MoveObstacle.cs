using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1 * 6 * Time.deltaTime, 0, 0);
    }
}
