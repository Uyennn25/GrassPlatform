using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckDied : MonoBehaviour
{
    public Text gameOverText;
   
    public void playerDied()
    {
        gameOverText.enabled = true;
        Time.timeScale = 0;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        playerDied();
        Time.timeScale = 0;
    }
}
