using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float updownSpeed;
    private float verticalInput;

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        // Move the player to the right
        transform.Translate(1 * speed * Time.deltaTime, 0, 0);
        // Move player up/down based on input
        transform.Translate(0, 1 * updownSpeed * verticalInput * Time.deltaTime, 0);
    }
}
