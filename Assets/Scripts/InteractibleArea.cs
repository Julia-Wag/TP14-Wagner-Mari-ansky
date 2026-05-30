using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractibleArea : MonoBehaviour
{
   public int score = 0;

    public int maxScore = 5;

    private UIManager uiManager;

    private bool juegoTerminado = false;

    private void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
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

                uiManager.MostrarPantallaWin();

                Time.timeScale = 0;
            }
        }
    }
}
