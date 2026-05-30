using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public float timer = 30f;

    private UIManager uiManager;

    public bool juegoTerminado = false;

    private void Start()
    {
        Time.timeScale = 1;

        uiManager = FindObjectOfType<UIManager>();
    }

    private void Update()
    {
        if (!juegoTerminado)
        {
            timer -= Time.deltaTime;

            uiManager.UpdateTimer(timer);

            if (timer <= 0)
            {
                timer = 0;

                juegoTerminado = true;

                uiManager.MostrarPantallaGameOver();

                Time.timeScale = 0;
            }
        }

        if (juegoTerminado && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
