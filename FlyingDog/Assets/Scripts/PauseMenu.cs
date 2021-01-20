using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    public bool isPlaying;

    private GameObject pausePanel;
    private GameObject pauseBtn;
    private GameObject ripImage;
    private GameObject score;
    private GameObject angelOne;
    private GameObject angelTwo;

    private void Start()
    {
        isPlaying = false;
        pausePanel = GameObject.Find("Pause");
        pausePanel.SetActive(false);
        pauseBtn = GameObject.Find("Button");
        pauseBtn.SetActive(false);
        ripImage = GameObject.Find("Image");
        ripImage.SetActive(false);
        score = GameObject.Find("Score");
        angelOne = GameObject.Find("AngelOne");
        angelOne.SetActive(false);
        angelTwo = GameObject.Find("AngelTwo");
        angelTwo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            Time.timeScale = 0;
            // Pause audio
            AudioListener.pause = true;

            pausePanel.SetActive(true);
            pauseBtn.SetActive(true);
            ripImage.SetActive(true);
            angelOne.SetActive(true);
            angelTwo.SetActive(true);

            score.transform.localPosition = new Vector3(0, -42f, 0);
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
