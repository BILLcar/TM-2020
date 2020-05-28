using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loss : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ballTag"))
        {
            GameObject.Find("ball").GetComponent<ballcontroller>().Reset();
            GameObject.Find("gameManagerObject").GetComponent<manager>().Reset();
            GameObject.Find("player1").GetComponent<paddle>().Reset();
        }
    }
}