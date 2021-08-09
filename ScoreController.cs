using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Implement TCP Client functionality so we can send data to C# TCP server and from there upload to MySQL
// Website leaderboard will read from MySQL with PHP or something else

public class ScoreController : MonoBehaviour
{

    Score score = new Score();

    private bool firstSpawn;
    private bool waitingSpawn;

    void Start()
    {
        waitingSpawn = true;
        firstSpawn = true;
    }

    void Update()
    {
        // Wait until we reach first obstacle
        if (firstSpawn)
            StartCoroutine(FirstSpawn());

        // Check the random result and spawn obstacle
        if (waitingSpawn && !firstSpawn)
            StartCoroutine(ScoreTimer());

        gameObject.GetComponent<Text>().text = "Score: " + score.GetScore();
    }

    IEnumerator ScoreTimer()
    {
        waitingSpawn = false;
        score.AddScore(1);
        yield return new WaitForSeconds(1);
        waitingSpawn = true;
    }

    IEnumerator FirstSpawn()
    {
        yield return new WaitForSeconds(3.5f);
        firstSpawn = false;
    }
}
