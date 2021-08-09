using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        GameObject.Find("Canvas").GetComponent<PauseMenu>().isPlaying = true;
    }
}
