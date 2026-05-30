using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractibleArea : MonoBehaviour
{
   private TimerScript timerScript;

   public int score = 0;

    public int maxScore = 5;

    private UIManager uiManager;

    private bool juegoTerminado = false;

    private void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
        timerScript = FindObjectOfType<TimerScript>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Lapicera"))
        {
            score++;

            uiManager.UpdateScore(score);

            Destroy(col.gameObject);

            if (score >= maxScore && !juegoTerminado)
            {
                juegoTerminado = true;

                timerScript.juegoTerminado = true;

                uiManager.MostrarPantallaWin();

                Time.timeScale = 0;

            }
        }
    }
}
