﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class manager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Score UI")]
    public GameObject player1text;

    private int playerScore;

    public void Player1Scored()
    {
        playerScore++;
        player1text.GetComponent<TextMeshProUGUI>().text = playerScore.ToString();
        ball.GetComponent<ballcontroller>().increaseSpeed();
    }

    public void Reset()
    {
        playerScore = 0;
        player1text.GetComponent<TextMeshProUGUI>().text = playerScore.ToString();
    }
}