using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private bool isPlaying;

    private void Start()
    {
        isPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPlaying)
            {
                isPlaying = false;
                Debug.Log("Pause menu");
            }
            else
            {
                isPlaying = true;
                Debug.Log("Unpause");
            } 
        }
    }
}
