using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.SetActive(false);
    }
}
