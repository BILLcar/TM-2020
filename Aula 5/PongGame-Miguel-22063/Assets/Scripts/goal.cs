using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ballTag"))
        {
            GameObject.Find("gameManagerObject").GetComponent<manager>().Player1Scored();
        }
    }
}
