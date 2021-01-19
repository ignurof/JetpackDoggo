using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public float speed;
    private float updownSpeed = 10;
    private float verticalInput;

    // Update is called once per frame
    void Update()
    {
        // Limit movement to game view
        if (transform.position.y >= 7.5f)
            transform.position = new Vector3(-15.63f, 7.5f, 0);
        else if (transform.position.y <= -7.5f)
            transform.position = new Vector3(-15.63f, -7.5f, 0);

        verticalInput = Input.GetAxis("Fire1");
        // Move the player to the right
        //transform.Translate(1 * speed * Time.deltaTime, 0, 0);
        // Move player up/down based on input
        if(verticalInput >= 0.1f)
        {
            transform.Translate(0, 1 * updownSpeed * Time.deltaTime, 0);
        }
        else
        {
            transform.Translate(0, -1 * updownSpeed * Time.deltaTime, 0);
        }
    }
}
