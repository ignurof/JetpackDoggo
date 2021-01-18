using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    private bool isPlaying;

    private GameObject pausePanel;
    private GameObject pauseBtn;

    private void Start()
    {
        isPlaying = true;
        pausePanel = GameObject.Find("Pause");
        pausePanel.SetActive(false);
        pauseBtn = GameObject.Find("Button");
        pauseBtn.SetActive(false);
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
                Time.timeScale = 0;
                // Pause audio
                AudioListener.pause = true;

                pausePanel.SetActive(true);
                pauseBtn.SetActive(true);
                
            }
            else
            {
                isPlaying = true;
                Debug.Log("Unpause");
                Time.timeScale = 1;
                AudioListener.pause = false;

                pausePanel.SetActive(false);
                pauseBtn.SetActive(false);
            } 
        }
    }

    // This function gets called when the Quit button is clicked
    // The special #if can check if we are in Editor or Build
    public void QuitGame()
    {
        // save any game data here
#if     UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
